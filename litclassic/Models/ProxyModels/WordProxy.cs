using litclassic.Models.WordModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litclassic.Models.ProxyModels
{
    public class WordProxy : IWordProxy
    {
        private readonly ILogger<WordProxy> _logger;
        private readonly LitClassicBooksContext _db;

        public WordProxy(ILogger<WordProxy> logger, LitClassicBooksContext db)
        {
            _logger = logger;
            _db = db;
        }

        public Word GetWord(int id)
        {
            var word = NewWord(id);

            return word;
        }
        public Word GetRandomWord()
        {
            var id = NewRandomId();
            var word = NewWord(id);

            return word;
        }
        public List<Word> GetRandomWords(int count)
        {
            var words = new List<Word>();

            for (int i = 0; i < count; i++)
            {
                var id = NewRandomId();
                var word = NewWord(id);

                words.Add(word);
            }

            return words;
        }
       
        private Word NewWord(int id)
        {
            // получение строки ссылок
            var links = _db.Words.Where(a => a.Id == id).Select(b => b.Links).Single();

            Word word = new Word()
            {
                Id = id,
                Name = _db.Words.Where(a => a.Id == id).Select(b => b.Name).Single(),
                Value = _db.Words.Where(a => a.Id == id).Select(b => b.Value).Single(),
                Links = links,
                // сбор списка слов из строки ссылок
                WordsInLinks = BuildWordsInLinks(links)
            };

            return word;
        }
        private int NewRandomId()
        {
            var rnd = new Random();
            int id = 0;
            var exit = false;

            // пока не будет найден существующий id
            while (!exit)
            {
                // случайный id от нуля до максимального id в Words
                id = rnd.Next(0, _db.Words.Max(a => a.Id));
                // проверка существования id
                exit = _db.Words.Any(b => b.Id == id);
            }
            
            return id;
        }
        private List<Word> BuildWordsInLinks(string links)
        {
            List<Word> wordsInLinks = new List<Word>();

            // если ссылки вообще есть
            if (links != "-1")
            {
                string[] linksArray = links.Split(';');
                List<int> listLinks = new List<int>();

                // последний элемент - пустой
                for (int i = 0; i < linksArray.Length - 1; i++)
                {
                    // проверка на повторяемость ссылки
                    if (listLinks.IndexOf(Convert.ToInt32(linksArray[i])) == -1)
                    {
                        listLinks.Add(Convert.ToInt32(linksArray[i]));
                        wordsInLinks.Add(NewWord(Convert.ToInt32(linksArray[i])));
                    }
                }
            }

            return wordsInLinks;
        }
    }
}

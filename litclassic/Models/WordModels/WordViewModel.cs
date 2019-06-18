using litclassic.LitClassicBooksModels;
using litclassic.Models.ProxyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litclassic.Models.WordModels
{
    public class WordViewModel
    {
        // TODO
        // задуматься о правильном использовании коллекций
        // https://docs.microsoft.com/ru-ru/dotnet/standard/design-guidelines/guidelines-for-collections

        private readonly IWordProxy _wordProxy;
        private readonly LitClassicBooksContext _db;

        public WordViewModel(IWordProxy wordProxy, LitClassicBooksContext db)
        {
            _wordProxy = wordProxy;
            _db = db;
        }

        public Word Word { get; set; }
        public List<Word> Words { get; set; }

        public void BuildModel(int id)
        {
            Word = _wordProxy.GetWord(id);
        }
        public void BuildModel(bool random, int wordsCount)
        {
            Words = _wordProxy.GetRandomWords(wordsCount);
        }      
    }
}

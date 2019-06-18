using litclassic.LitClassicBooksModels;
using litclassic.Models.ProxyModels;
using System.Collections.Generic;

namespace litclassic.Models.ParticleModels
{
    /// <summary>
    /// Model of particle view
    /// </summary>
    public class ParticleViewModel
    {
        // TODO
        // задуматься о правильном использовании коллекций
        // https://docs.microsoft.com/ru-ru/dotnet/standard/design-guidelines/guidelines-for-collections

        private readonly IParticleProxy _particleProxy;
        private readonly IParticleParamsProxy _particleParamsProxy;
        private readonly LitClassicBooksContext _db;

        public ParticleViewModel(IParticleProxy particleProxy, IParticleParamsProxy particleParamsProxy, LitClassicBooksContext db)
        {
            _particleProxy = particleProxy;
            _particleParamsProxy = particleParamsProxy;
            _db = db;
        }

        public ParticlePartialViewModel ParticlePartialViewModel { get; private set; }
        public ParticleParams ParticleParams { get; private set; }

        public void BuildModel(int particlesCount)
        {
            ParticlePartialViewModel = new ParticlePartialViewModel(_particleProxy, _db);
            ParticleParams = new ParticleParams
            {
                Authors = new List<string> { "Ф.М. Достоевский", "А.С. Пушкин", "Н.В. Гоголь", "В.А.Жуковский", "Иван Андреевич Крылов", "М.Ю. Лермонтов", "Фёдор Иванович Тютчев", " А.К. Толстой", "М.В. Ломоносов"},
                ThemeTypes = new List<string> { "Основные произведения", "Прочие произведения, заметки, письма и пр.", "Примечания, приложения, комментарии и пр." }
            };

            ParticlePartialViewModel.BuildModel(particlesCount);
        }
    }
}

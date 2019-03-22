using litclassic.Models.ProxyModels;
using System.Collections.Generic;

namespace litclassic.Models.ParticleModels
{
    public class ParticleViewModel
    {
        // TODO
        // задуматься о правильном использовании коллекций
        // https://docs.microsoft.com/ru-ru/dotnet/standard/design-guidelines/guidelines-for-collections

        private readonly IParticleProxy _particleProxy;
        private readonly LitClassicBooksContext _db;

        public ParticleViewModel(IParticleProxy particleProxy, LitClassicBooksContext db)
        {
            _particleProxy = particleProxy;
            _db = db;
        }

        public List<Particle> Particles { get; private set; }
        public Particle Particle { get; private set; }

        public void BuildModel(bool random, int particlesCount)
        {
            Particles = _particleProxy.GetRandomParticles(particlesCount);
        }
        public void BuildModel(int id)
        {
            Particle = _particleProxy.GetParticle(id);
        }
    }
}

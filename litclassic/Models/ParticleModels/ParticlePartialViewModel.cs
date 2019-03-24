using litclassic.Models.ProxyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litclassic.Models.ParticleModels
{
    public class ParticlePartialViewModel
    {
        private readonly IParticleProxy _particleProxy;
        private readonly LitClassicBooksContext _db;

        public ParticlePartialViewModel(IParticleProxy particleProxy, LitClassicBooksContext db)
        {
            _particleProxy = particleProxy;
            _db = db;
        }

        public List<Particle> Particles { get; private set; }

        public void BuildModel(int particlesCount)
        {
            Particles = _particleProxy.GetRandomParticles(particlesCount);
        }
    }
}

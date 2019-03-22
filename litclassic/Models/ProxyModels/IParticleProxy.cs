using litclassic.Models.ParticleModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litclassic.Models.ProxyModels
{
    public interface IParticleProxy
    {
        Particle GetRandomParticle();
        Particle GetParticle(int id);
        List<Particle> GetRandomParticles(int count);
    }
}

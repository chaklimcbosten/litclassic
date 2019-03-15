using litclassic.Models.Connect;
using System.Collections.Generic;

namespace litclassic.Models.Particle
{
    public class ParticleViewModel
    {
        public bool Random { get; set; }
        public int ParticlesCount { get; set; }
        public List<Particle> Particles { get; set; }
        public Particle Particle { get; set; }

        public void BuildModel(bool random, int particlesCount)
        {
            Particles = new ConnectParticle().GetRandomParticles(particlesCount);
        }

        public void BuildModel(int id)
        {
            Particle = new ConnectParticle().GetParticle(id);
        }
    }
}

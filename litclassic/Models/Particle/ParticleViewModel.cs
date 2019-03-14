using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litclassic.Models.Particle
{
    public class ParticleViewModel
    {
        public bool Random { get; set; }
        public int ParticlesCount { get; set; }
        public List<Particle> Particles { get; set; }

        public void BuildParticles()
        {

        }
    }
}

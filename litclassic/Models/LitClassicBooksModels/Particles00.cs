using System;
using System.Collections.Generic;

namespace litclassic
{
    public partial class Particles00
    {
        public int Id { get; set; }
        public int Idparticles { get; set; }
        public DateTime? UpdateDateTime { get; set; }

        public virtual Particles IdparticlesNavigation { get; set; }
    }
}

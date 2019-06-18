using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litclassic.Models.ParticleModels
{
    /// <summary>
    /// Particle model
    /// </summary>
    public struct Particle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Dictionary<string,string> Author { get; set; }
        public string Artwork { get; set; }
        public string Body { get; set; }
        public List<string> BodyLines { get; set; }
        public ParticleParams ParticleParams { get; set; }
    }
}

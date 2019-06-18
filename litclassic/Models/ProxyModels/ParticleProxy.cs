using litclassic.LitClassicBooksModels;
using litclassic.Models.ParticleModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litclassic.Models.ProxyModels
{
    public class ParticleProxy : IParticleProxy
    {
        private readonly ILogger<ParticleProxy> _logger;
        private readonly LitClassicBooksContext _db;

        public ParticleProxy(ILogger<ParticleProxy> logger, LitClassicBooksContext db)
        {
            _logger = logger;
            _db = db;
        }

        public Particle GetRandomParticle()
        {
            var id = NewRandomId();
            var particle = NewParticle(id);

            // TODO
            // получение автора "частицы" и произведения "частицы"

            return particle;
        }
        public Particle GetParticle(int id)
        {
            var particle = NewParticle(id);

            // TODO
            // получение автора "частицы" и произведения "частицы"  

            return particle;
        }
        public List<Particle> GetRandomParticles(int count)
        {
            var particles = new List<Particle>();

            for (int i = 0; i < count; i++)
            {
                var id = NewRandomId();
                var particle = NewParticle(id);

                particles.Add(particle);

                // TODO
                // получение автора "частицы" и произведения "частицы"
            }

            return particles;
        }

        private Particle NewParticle(int id)
        {
            var body = _db.Particles.Where(a => a.Id == id).Select(b => b.Line).Single();

            //body = body.Replace("$$emphasis-open$$", "<emphasis>");
            //body = body.Replace("$$emphasis-close$$", "</emphasis>");
            //body = body.Replace("$$strong-open$$", "<strong>");
            //body = body.Replace("$$strong-close$$", "</strong>");

            body = body.Replace("$$emphasis-open$$", "");
            body = body.Replace("$$emphasis-close$$", "");
            body = body.Replace("$$strong-open$$", "");
            body = body.Replace("$$strong-close$$", "");

            Particle particle = new Particle()
            {
                Id = id,
                Title = _db.Particles.Where(a => a.Id == id).Select(b => b.Title).Single(),
                Body = body,
                BodyLines = BuildBodyLines(body)
            };

            return particle;
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
                id = rnd.Next(0, _db.Particles.Max(a => a.Id));
                // проверка существования id
                exit = _db.Particles.Any(b => b.Id == id);
            }

            return id;
        }
        private List<string> BuildBodyLines(string body)
        {
            var bodyLines = new List<string>();

            foreach (string line in body.Split("\n\r"))
            {
                bodyLines.Add(line);
            }

            return bodyLines;
        }
    }
}

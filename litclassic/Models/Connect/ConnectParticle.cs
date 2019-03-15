using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using litclassic.Models.Particle;

namespace litclassic.Models.Connect
{
    public class ConnectParticle : Connect
    {
        // TODO
        // достать одну "частицу" по id, предполагая, что может не быть такого id
        // достать заданное количество "частиц" одним списком по их id, предполагая, что может не быть таких id
        // посмотреть, какое максимальное id "частиц"

        public Particle.Particle GetRandomParticle()
        {
            Particle.Particle particle;

            using (LitClassicBooksContext db = new LitClassicBooksContext())
            {
                var rnd = new Random();
                var id = rnd.Next(0, db.Particles.Count());

                particle = new Particle.Particle()
                {
                    Id = id,
                    Title = db.Particles.ElementAt(id).Title,
                    Body = db.Particles.ElementAt(id).Line
                };
            }

            return particle;
        }
        public Particle.Particle GetParticle(int id)
        {
            Particle.Particle particle;

            using (LitClassicBooksContext db = new LitClassicBooksContext())
            {
                particle = new Particle.Particle()
                {
                    Id = id,
                    Title = db.Particles.ElementAt(id).Title,
                    Body = db.Particles.ElementAt(id).Line
                };
            }

            return particle;
        }
        public List<Particle.Particle> GetRandomParticles(int count)
        {
            List<Particle.Particle> particles = new List<Particle.Particle>();         

            using (LitClassicBooksContext db = new LitClassicBooksContext())
            {
                for (int i = 0; i < count; i++)
                {
                    Particle.Particle particle;
                    var rnd = new Random();
                    var id = rnd.Next(0, db.Particles.Count());

                    particle = new Particle.Particle()
                    {
                        Id = id,
                        Title = db.Particles.ElementAt(id).Title,
                        Body = db.Particles.ElementAt(id).Line
                    };

                    particles.Add(particle);
                }
            }

            return particles;
        }
    }
}

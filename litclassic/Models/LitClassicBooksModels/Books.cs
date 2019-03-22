using System;
using System.Collections.Generic;

namespace litclassic
{
    public partial class Books
    {
        public Books()
        {
            BooksDescriptions = new HashSet<BooksDescriptions>();
            BooksLines = new HashSet<BooksLines>();
            Particles = new HashSet<Particles>();
        }

        public int Id { get; set; }
        public string BookPath { get; set; }
        public DateTime? UpdateDateTime { get; set; }

        public virtual ICollection<BooksDescriptions> BooksDescriptions { get; set; }
        public virtual ICollection<BooksLines> BooksLines { get; set; }
        public virtual ICollection<Particles> Particles { get; set; }
    }
}

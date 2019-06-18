using System;
using System.Collections.Generic;

namespace litclassic.LitClassicBooksModels
{
    public partial class Particles
    {
        public Particles()
        {
            Particles00 = new HashSet<Particles00>();
            Particles01 = new HashSet<Particles01>();
            Particles02 = new HashSet<Particles02>();
            Particles03 = new HashSet<Particles03>();
            Particles10 = new HashSet<Particles10>();
            Particles11 = new HashSet<Particles11>();
            Particles12 = new HashSet<Particles12>();
            Particles13 = new HashSet<Particles13>();
            Particles20 = new HashSet<Particles20>();
            Particles21 = new HashSet<Particles21>();
            Particles22 = new HashSet<Particles22>();
            Particles23 = new HashSet<Particles23>();
            Particles30 = new HashSet<Particles30>();
            Particles31 = new HashSet<Particles31>();
            Particles32 = new HashSet<Particles32>();
            Particles33 = new HashSet<Particles33>();
            Particles40 = new HashSet<Particles40>();
            Particles41 = new HashSet<Particles41>();
            Particles42 = new HashSet<Particles42>();
            Particles43 = new HashSet<Particles43>();
            Particles50 = new HashSet<Particles50>();
            Particles51 = new HashSet<Particles51>();
            Particles52 = new HashSet<Particles52>();
            Particles53 = new HashSet<Particles53>();
            Particles60 = new HashSet<Particles60>();
            Particles61 = new HashSet<Particles61>();
            Particles62 = new HashSet<Particles62>();
            Particles63 = new HashSet<Particles63>();
            Particles70 = new HashSet<Particles70>();
            Particles71 = new HashSet<Particles71>();
            Particles72 = new HashSet<Particles72>();
            Particles73 = new HashSet<Particles73>();
            Particles80 = new HashSet<Particles80>();
            Particles81 = new HashSet<Particles81>();
            Particles82 = new HashSet<Particles82>();
            Particles83 = new HashSet<Particles83>();
            Particles90 = new HashSet<Particles90>();
            Particles91 = new HashSet<Particles91>();
            Particles92 = new HashSet<Particles92>();
            Particles93 = new HashSet<Particles93>();
        }

        public int Id { get; set; }
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Line { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public int? IndexLastLine { get; set; }
        public int? SumStrongConnections { get; set; }

        public virtual Books Book { get; set; }
        public virtual ICollection<Particles00> Particles00 { get; set; }
        public virtual ICollection<Particles01> Particles01 { get; set; }
        public virtual ICollection<Particles02> Particles02 { get; set; }
        public virtual ICollection<Particles03> Particles03 { get; set; }
        public virtual ICollection<Particles10> Particles10 { get; set; }
        public virtual ICollection<Particles11> Particles11 { get; set; }
        public virtual ICollection<Particles12> Particles12 { get; set; }
        public virtual ICollection<Particles13> Particles13 { get; set; }
        public virtual ICollection<Particles20> Particles20 { get; set; }
        public virtual ICollection<Particles21> Particles21 { get; set; }
        public virtual ICollection<Particles22> Particles22 { get; set; }
        public virtual ICollection<Particles23> Particles23 { get; set; }
        public virtual ICollection<Particles30> Particles30 { get; set; }
        public virtual ICollection<Particles31> Particles31 { get; set; }
        public virtual ICollection<Particles32> Particles32 { get; set; }
        public virtual ICollection<Particles33> Particles33 { get; set; }
        public virtual ICollection<Particles40> Particles40 { get; set; }
        public virtual ICollection<Particles41> Particles41 { get; set; }
        public virtual ICollection<Particles42> Particles42 { get; set; }
        public virtual ICollection<Particles43> Particles43 { get; set; }
        public virtual ICollection<Particles50> Particles50 { get; set; }
        public virtual ICollection<Particles51> Particles51 { get; set; }
        public virtual ICollection<Particles52> Particles52 { get; set; }
        public virtual ICollection<Particles53> Particles53 { get; set; }
        public virtual ICollection<Particles60> Particles60 { get; set; }
        public virtual ICollection<Particles61> Particles61 { get; set; }
        public virtual ICollection<Particles62> Particles62 { get; set; }
        public virtual ICollection<Particles63> Particles63 { get; set; }
        public virtual ICollection<Particles70> Particles70 { get; set; }
        public virtual ICollection<Particles71> Particles71 { get; set; }
        public virtual ICollection<Particles72> Particles72 { get; set; }
        public virtual ICollection<Particles73> Particles73 { get; set; }
        public virtual ICollection<Particles80> Particles80 { get; set; }
        public virtual ICollection<Particles81> Particles81 { get; set; }
        public virtual ICollection<Particles82> Particles82 { get; set; }
        public virtual ICollection<Particles83> Particles83 { get; set; }
        public virtual ICollection<Particles90> Particles90 { get; set; }
        public virtual ICollection<Particles91> Particles91 { get; set; }
        public virtual ICollection<Particles92> Particles92 { get; set; }
        public virtual ICollection<Particles93> Particles93 { get; set; }
    }
}

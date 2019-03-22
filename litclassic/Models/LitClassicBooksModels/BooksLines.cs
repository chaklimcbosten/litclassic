using System;
using System.Collections.Generic;

namespace litclassic
{
    public partial class BooksLines
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Line { get; set; }
        public string Title { get; set; }
        public int? StrongConnection { get; set; }
        public int? RecommendConnection { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public int? LineIndex { get; set; }

        public virtual Books Book { get; set; }
    }
}

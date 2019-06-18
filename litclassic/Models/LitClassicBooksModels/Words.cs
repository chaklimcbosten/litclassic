using System;
using System.Collections.Generic;

namespace litclassic.LitClassicBooksModels
{
    public partial class Words
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Links { get; set; }
        public string FirstLetter { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}

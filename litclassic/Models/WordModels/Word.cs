using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litclassic.Models.WordModels
{
    public struct Word
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Links { get; set; }
        public List<Word> WordsInLinks { get; set; }
    }
}

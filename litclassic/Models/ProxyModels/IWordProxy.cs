using litclassic.Models.WordModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litclassic.Models.ProxyModels
{
    public interface IWordProxy
    {
        Word GetRandomWord();
        Word GetWord(int id);
        List<Word> GetRandomWords(int count);
    }
}

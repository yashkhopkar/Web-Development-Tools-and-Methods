using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class WordCounterModel
    {
        public string WordCounter { get; set; }

        public Dictionary<string, int> wordDict { get; set; }
    }
}

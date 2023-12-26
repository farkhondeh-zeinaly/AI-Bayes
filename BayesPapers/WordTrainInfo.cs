using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BayesPapers
{
    public class WordTrainInfo
    {
        public string Word { get; set; }
        public Dictionary<int, int> CategoryCount { get; set; }
    }
}

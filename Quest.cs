using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Text_adventure2._0
{
    public class Quest
    {
        public float iD { get; set; }
        public string StartText { get; set; }
        public List<string> Options { get; set; }
        public int CompleteIndex { get; set; }
        public bool Complete { get; set; }
        public Quest(float id, string starttext, List<string> options, int index, bool complete)
        {
            iD = id;
            StartText = starttext;
            Options = options;
            CompleteIndex = index;
            Complete = complete;
        }

    }
}


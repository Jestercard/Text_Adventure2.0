using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure2._0
{
    public static class QuestList
    {
        private static string q1start = "You awaken in a cave unsure of where to go next";
        private static List<string> q1options = new List<string>{"walk forward", "look around" };
        public static Quest q1 = new Quest(1,q1start,q1options,0,false);

        private static string q2start = "This is the next quest! :D";
        private static List<string> q2options = new List<string> { "walk forward", "look around" };
        public static Quest q2 = new Quest(1, q2start, q2options, 0, false);

        public static List<Quest> questmasterlist = new List<Quest>() { q1, q2 };
    }
}
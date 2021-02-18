using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure2._0
{
    public static class QuestMethods
    {
        public static Quest GetQuestFromID(float id, List<Quest> masterlist)
        {
            List<string> dummylist = new List<string>();
            Quest currentquest = new Quest(0, "0", dummylist, 0, false);
            foreach (Quest q in masterlist)
            {
                if (id == q.iD)
                {
                    currentquest = q;
                    break;
                }
            }
            return currentquest;
        }

        public static bool CheckQuestForCompletion(int chosenoption, int completionoption)
        {
            if (chosenoption == completionoption)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure2._0
{
    public class AnswerChecker
    {
        private Quest queststats;
        private Player playerstats;

        bool hasItem = false;
        bool hasAnswer = false;
        bool completionanswer = false;

        public string playeranswer;
        public string[] Verbs = new string[3] { "run", "walk", "jog" };

        public AnswerChecker(Quest quest, Player player)
        {
            queststats = quest;
            playerstats = player;
        }

        public string PlayerAnswer()
        {
            Console.WriteLine("What do you do?");
            Console.WriteLine("");
            playeranswer = Console.ReadLine().ToLower();
            Console.WriteLine("");
            return playeranswer;
        }
        public void CheckAnswer()
        {
            hasItem = false;
            hasAnswer = false;
            completionanswer = false;

            int pos = Array.IndexOf(Verbs, playeranswer);
            if (pos > -1)
            {
                Console.WriteLine("Where do you want to {0}?", playeranswer);
            }
            else if (playeranswer == "options")
            {
                Console.WriteLine("Here are the actions you can take:");
                foreach (var q in queststats.Options)
                {
                    Console.WriteLine("- {0}", q);
                }
            }
            else if (playeranswer == "exit")
            {
                Console.WriteLine("Are you sure you want to exit? Y/N");
                string playeranswer2 = Console.ReadLine().ToLower();
                if (playeranswer2 == "y" || playeranswer2 == "yes")
                {
                    System.Environment.Exit(0);
                }
            }
            else
            {
                foreach (InventoryItem ii in playerstats.PlayerInventory)
                {
                    if (playeranswer == ii.itemName.ToLower())
                    {
                        hasItem = true;
                        Console.WriteLine("{0}: {1}", ii.itemName, ii.itemDescription);
                        Console.WriteLine("Do you want to use the item? Y/N");
                        string playeranswer2 = Console.ReadLine();
                        if (playeranswer2 == "y" || playeranswer2 == "yes")
                        {
                            Console.WriteLine("");
                            ii.UseItem(playerstats);
                            playerstats.PlayerInventory.Remove(ii);
                        }
                        break;
                    }
                }
                foreach (string qa in queststats.Options)
                {
                    int indexofchosenquest = 99;
                    if (playeranswer == qa.ToLower())
                    {
                        Console.WriteLine("This is an answer!");
                        hasAnswer = true;
                        indexofchosenquest = qa.IndexOf(playeranswer);
                        completionanswer = QuestMethods.CheckQuestForCompletion(indexofchosenquest, queststats.CompleteIndex);
                        ///change quest id or interaction based on quest
                    }
                }
                if (hasItem == false && hasAnswer == false)
                {
                    Console.WriteLine("You do not know how to or cannot {0}", playeranswer);
                }
            }
        }
        public float AdvanceToNextQuest(float questID)
        {
            if (completionanswer)
            {
                return questID + 1;
            }
            else
            {
                return questID;
            }
        }
    }
}

using System;
using System.Threading;

namespace Text_adventure2._0
{
    public class UserInterface
    {
        //Time in ms to delay next text
        public void DelayTimer()
        {
            Thread.Sleep(50);
        }
        //TODO add typewriter like option for text to appear on screen

        //Splash screen
        public void Header()
        {
            Console.WriteLine("______________________________________________");
            Console.WriteLine("_____________TEXT ADVENTURE___________________");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Here are the instructions for playing the game.");
            DelayTimer();
            Console.WriteLine("Type only when you see a grammatical colon ':'.");
            DelayTimer();
            Console.WriteLine("At any time, you can enter [options] to see what actions you can do.");
            DelayTimer();
            Console.WriteLine("Have fun!");
            Console.WriteLine();
            Console.WriteLine();
            DelayTimer();
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }

        //Permanently display stats and inventory on each quest screen
        public void DisplayStatsAndInventory(Player playerstats)
        {
            Console.WriteLine("Level: {0}", playerstats.playerLevel);
            Console.WriteLine("Armor: {0} / {1}", playerstats.armor, playerstats.maxArmor);
            Console.WriteLine("Health: {0} / {1}", playerstats.health, playerstats.maxHealth);
            Console.WriteLine("");
            Console.WriteLine("Inventory:");
            foreach (InventoryItem q in playerstats.PlayerInventory)
            {
                Console.WriteLine("- {0}", q.itemName);
            }
        }

        public void JourneyStart(Player player)
        {
            bool storyfinished = false;
            float questID = 1;
            DelayTimer();
            while (storyfinished == false)
            {
                Quest currentquest = QuestMethods.GetQuestFromID(questID, QuestList.questmasterlist);
                Console.Clear();
                DisplayStatsAndInventory(player);
                Console.WriteLine("");
                Console.WriteLine(currentquest.StartText);
                AnswerChecker ac = new AnswerChecker(currentquest, player);
                ac.PlayerAnswer();
                ac.CheckAnswer();
                questID = ac.AdvanceToNextQuest(questID);
                Console.WriteLine("");
                Console.WriteLine("Press a key to continue");
                Console.ReadKey();
            }
        }
    }
}


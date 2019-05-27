using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Text_adventure2._0
{
    class Header
    {
        public Header()
        {
            Console.WriteLine("______________________________________________");
            Console.WriteLine("_____________TEXT ADVENTURE___________________");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public void Setupheader()
        {
            Console.WriteLine("Here are the instructions for playing the game.");
            Thread.Sleep(500);
            Console.WriteLine("Type only when you see a grammatical colon ':'.");
            Thread.Sleep(500);
            Console.WriteLine("At any time, you can enter [options] to see what actions you can do.");
            Thread.Sleep(500);
            Console.WriteLine("You also have an [inventory] and [stats] as well");
            Thread.Sleep(500);
            Console.WriteLine("Have fun!");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    class Creature
    {
        public int health;
        public int armor;
    }
    class Player : Creature
    {
        public int player_level;
    }
    class Monster : Creature
    {
        public Monster()
        {
            Console.WriteLine("A Wild Monster Appears!");
        }
    }
    class Quest
    {
        public string QuestStartText;
        public String[] QuestOptoins;
        public String[] Verbs = new String[3] { "run", "walk", "jog" };
        string Playeranswer;
        bool questcomplete;
        public void QuestStart()
        {
            Console.Write(QuestStartText);
            Thread.Sleep(500);
            while (questcomplete == false)
            {
                PlayerAnswer();
                CheckAnswer();
            }
        }
        private string PlayerAnswer()
        {
            Console.WriteLine("");
            Console.WriteLine("What do you do?");
            Playeranswer = Console.ReadLine();
            return Playeranswer;
        }
        private void CheckAnswer()
        {
            int pos = Array.IndexOf(Verbs, Playeranswer);
            if (pos > -1)
            {
                Console.WriteLine("Where do you want to {0}?", Playeranswer);
            }
            else if (Playeranswer == QuestOptoins[0])
            {
                questcomplete = true;
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }

    }
    class Program
    {
        static void Main(String[] args)
        {
            Player p1 = new Player();
            p1.health = 100;
            p1.armor = 0;
            p1.player_level = 1;

            Header h = new Header();
            Thread.Sleep(500);
            h.Setupheader();
            Thread.Sleep(500);

            Quest q1 = new Quest();
            q1.QuestStartText = "You wake up in a cave unsure of what to do next.";
            q1.QuestOptoins = new string[2] { "look around", "walk forward" };
            q1.QuestStart();
            Thread.Sleep(500);

            Quest q2 = new Quest();
            q2.QuestStartText = "You look around and see a torch in the distance.";
            q2.QuestOptoins = new string[2] { "walk to light", "stumble" };
            q2.QuestStart();
        }

    }


}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Text_adventure2._0
{
    class Program
    {
        static void Main(String[] args)
        {
            //Player is instantiated
            Player p1 = new Player();
            p1.health = 50;
            p1.maxHealth = 100;
            p1.armor = 18;
            p1.maxArmor = 25;
            p1.playerLevel = 1;

            //Test Items (can be deleted once done testing)
            HealthPotion healthPotion = new HealthPotion();
            p1.PlayerInventory.Add(healthPotion);
            Armorplating armorplating = new Armorplating();
            p1.PlayerInventory.Add(armorplating);
            Armorplating armorplating2 = new Armorplating();
            p1.PlayerInventory.Add(armorplating2);

            //Initial splash screen and instructions
            UserInterface h = new UserInterface();
            h.Header();

            //Starts questing loop
            h.JourneyStart(p1);

            //Pauses at end of the story
            Console.ReadKey();
        }

    }


}

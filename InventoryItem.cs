using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure2._0
{
    public abstract class InventoryItem
    {

        public abstract string itemName { get; }
        public abstract string itemDescription { get; }
        public abstract void UseItem(Player player);
    }
    public class HealthPotion : InventoryItem
    {
        private int healthAmount = 5;
        private string itemname = "Health Potion";
        private string itemdescription = "Restores a small amount of health.";
        public override string itemName 
        { 
            get { return itemname; } 
        }
        public override string itemDescription 
        {
            get { return itemdescription; } 
        }
        public override void UseItem(Player player)
        {
            if (player.maxHealth - player.health >= healthAmount)
            {
                Console.WriteLine("You regenerated 5 health!");
                player.health = player.health + healthAmount;
            }
            else if (player.maxHealth - player.health != 0)
            {
                Console.WriteLine("You regenerated {0} health!", player.maxHealth - player.health);
                player.health = player.maxHealth;
            }
            else
            {
                Console.WriteLine("You are already at full health. Potion had no effect.");
            }
        }
    }
    public class Armorplating : InventoryItem
    {
        private int armorAmount = 5;
        private string itemname = "Armor Plating";
        private string itemdescription = "Restores a small amount of armor.";
        public override string itemName
        {
            get { return itemname; }
        }
        public override string itemDescription
        {
            get { return itemdescription; }
        }
        public override void UseItem(Player player)
        {
            if (player.maxArmor - player.armor>= armorAmount)
            {
                Console.WriteLine("You gained 5 armor!");
                player.armor = player.armor + armorAmount;
            }
            else if (player.maxArmor - player.armor != 0)
            {
                Console.WriteLine("You regenerated {0} armor!", player.maxArmor - player.armor);
                player.armor = player.maxArmor;
            }
            else
            {
                Console.WriteLine("You are already at full armor. Plating had no effect.");
            }
        }
    }
}

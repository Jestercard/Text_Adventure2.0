using System;
using System.Collections;
using System.Collections.Generic;

namespace Text_adventure2._0
{
    public class Creature
    {
        public int health;
        public int maxHealth;
        public int armor;
        public int maxArmor;
    }
    public class Player : Creature
    {
        public int playerLevel;
        public List<InventoryItem> PlayerInventory = new List<InventoryItem>();
    }
    public class Monster : Creature
    {
        //TODO need to add monster stats and test encounter
        public Monster()
        {
            Console.WriteLine("A Wild Monster Appears!");
        }
    }
}

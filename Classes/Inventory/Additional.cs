using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Inventory
{
    public class Additional
    {
        private string name;
        private int durability;
        private int resistance;
        private int health;
        private int hurt;
        private int intelligence;

        public string Name { get => name; set => name = value; }
        public int Durability { get => durability; set => durability = value; }
        public int Resistance { get => resistance; set => resistance = value; }
        public int Health { get => health; set => health = value; }
        public int Hurt { get => hurt; set => hurt = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
    }
}

using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment.Potions
{
    public class Potion : IDescribable
    {
        public string ShowInformation()
        {
            return "This is a strange potion";
        }
    }
}

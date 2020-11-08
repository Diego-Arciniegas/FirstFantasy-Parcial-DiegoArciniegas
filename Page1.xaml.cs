using FirstFantasy.Classes.Equipment.Armors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FirstFantasy.Classes.Inventory;

namespace FirstFantasy
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {

        public Page1()
        {

            InitializeComponent();


            Things Copper_Armor = new Things();
            Things Tunic = new Things();
            Things Magic_Barite = new Things();
            Things Potion_Of_Strength = new Things();

            Copper_Armor SA = new Copper_Armor();
            Tunic T = new Tunic();
            Magic_Barite MB = new Magic_Barite();
            Potion_Of_Strength POS = new Potion_Of_Strength();


            Copper_Armor.itemName = $"{SA.Name}";
            Copper_Armor.itemDescription = $"Durability = {SA.Durability} , Resistance = {SA.Resistance} , Health = {SA.Health}";

            Tunic.itemName = $"{T.Name}";
            Tunic.itemDescription = $"Durability = {T.Durability} , Resistance = {T.Resistance} , Healt = {T.Health} , Intelligence = {T.Intelligence}";

            Magic_Barite.itemName = $"{MB.Name}";
            Magic_Barite.itemDescription = $"Durability = {MB.Durability} , Resistance = {MB.Resistance} , Hurt = {MB.Hurt}";

            Potion_Of_Strength.itemName = $"{POS.Name}";
            Potion_Of_Strength.itemDescription = "Increase the " + POS.Health + "% of its strength.";


            DataGrid.Items.Add(Copper_Armor);
            DataGrid.Items.Add(Tunic);
            DataGrid.Items.Add(Magic_Barite);
            DataGrid.Items.Add(Potion_Of_Strength);

        }
        public class Things
        {
            public string itemName { get; set; }
            public string itemDescription { get; set; }
        }

    }

}



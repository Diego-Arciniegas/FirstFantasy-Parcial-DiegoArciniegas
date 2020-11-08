using FirstFantasy.Classes.Equipment;
using FirstFantasy.Classes.Equipment.Armors;
using FirstFantasy.Classes.Equipment.Weapons;
using FirstFantasy.Classes.Equipment.Potions;
using FirstFantasy.Classes.Player;

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

namespace FirstFantasy
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }
        Character myCharacter;
        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            TxtOutput.Text = "";

            switch (CboxCharacter.SelectedIndex)
            {
                case 1:
                    myCharacter = new Cleric();
                    break;

                case 2:
                    myCharacter = new Fighter();
                    break;

                case 3:
                    myCharacter = new Rouge();
                    break;

                case 4:
                    myCharacter = new Wizard();
                    break;

                default:
                    myCharacter = null;
                    MessageBox.Show("You MUST select a type");
                    break;

            }
            switch (CboxWeapon.SelectedIndex)
            {
                case 1:
                    myCharacter.Weapon = new Axe();
                    break;

                case 2:
                    myCharacter.Weapon = new Bow();
                    break;

                case 3:
                    myCharacter.Weapon = new Sword();
                    break;



                default:

                    MessageBox.Show("You MUST select a weapon");
                    break;

            }
            switch (CboxArmor.SelectedIndex)
            {
                case 1:
                    myCharacter.Armor = new Gold_Armor();
                    break;

                case 2:
                    myCharacter.Armor = new Silver_Armor();
                    break;

                case 3:
                    myCharacter.Armor = new Wooden_Armor();
                    break;

                default:

                    MessageBox.Show("You MUST select a weapon");
                    break;




            }
            TxtOutput.Text = "Name: " + txtName.Text + "\n" + "Type of warrior:: " + CboxCharacter.Text + "\n" + "Weapon: " + CboxWeapon.Text + "\n" + "Armor type: " + CboxArmor.Text;



        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            if (myCharacter != null)
            {

                txtAttackAlert.Text = "Tú " + CboxCharacter.Text + " " + txtName.Text + " Causo " + myCharacter.Hurt() + " de daño" + "\n" + "con una " + CboxWeapon.Text;

            }
        }

        private void BtnInventory_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new Page1());
        }


    }

}

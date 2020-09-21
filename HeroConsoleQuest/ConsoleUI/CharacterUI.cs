using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class CharacterUI
    {

        public static void Boarders()
        {
            Console.WriteLine();
            Color.Boarders("________________________________________________________________________________________");
            Console.WriteLine();
        }

        public static void CharacterInfoBar(string hero, int level, int health, int mana, int gold)
        {
            Console.Clear();
            Boarders();
            Color.HeaderColor($"        Hero: { hero }    Level: { level }    HP: { health }    MP: { mana }    Gold: { gold }");
            Boarders();
        }

        public static void CharacterStats(int attack, int deffence, int move)
        {
            Boarders();
            Color.OptionsColor($"Attack: { attack }\nDefend: { deffence }\nMove: { move }");
            Boarders();
        }

        public static string CharPassiveMenuSelection()
        {
            bool isValidNumber = false;
            string userSelection;

            do
            {
                Console.Clear();
                Boarders();
                Color.OptionsColor($"1. Move \n2. Inventory \n3. View Character Stats");
                Console.WriteLine();
                Console.Write("Selection: ");
                userSelection = Console.ReadLine();

                if (userSelection == "1")
                {
                    isValidNumber = true;
                }
                else if (userSelection == "2")
                {
                    isValidNumber = true;
                }
                else if (userSelection == "3")
                {
                    isValidNumber = true;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Enter a valid number...");
                    Console.ReadLine();
                }
            } while (isValidNumber == false);

            return userSelection;
        }
    }
}


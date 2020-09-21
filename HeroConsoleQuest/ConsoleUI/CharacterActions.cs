using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class CharacterActions
    {
        public static string AttackOptions()
        {
            bool isValidChoice = true;
            string playerChoice;

            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Color.HeaderColor("What would you like to do:");
                Color.OptionsColor($"1. Attack \n2. Spell \n3. Inventory \n4. Run Away");
                Console.WriteLine();
                Console.Write($"Choice: ");
                playerChoice = Console.ReadLine();

                if (playerChoice == "1")
                {
                    playerChoice = "attack";
                }
                else if (playerChoice == "2")
                {
                    playerChoice = "magic";
                }
                else if (playerChoice == "3")
                {
                    playerChoice = "inventory";
                }
                else if (playerChoice == "4")
                {
                    playerChoice = "run";
                }
                else
                {
                    Color.Danger("Sorry, your have entered an invalid option. Try Again...");
                    Console.ReadLine();
                    isValidChoice = false;
                }
            } while (isValidChoice == false);

            return playerChoice;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class Attacks
    {
        public static int PlayerAttack(int attack, int currentHealth, int defense)
        {
            int damage = attack - defense;

            currentHealth -= damage;

            return currentHealth;
        }

        public static int EnemyAttack(int attack, int currentHealth, int defense)
        {
            int damage = attack - defense;


            if (damage <= 0)
            {
                Console.WriteLine("You blocked the attack!");
                return currentHealth;
            }

            currentHealth -= damage;

            Console.WriteLine($"You have been attacked! You took { damage } damage.");
            Console.WriteLine($"Your current health is at { currentHealth }");

            Console.ReadLine();

            return currentHealth;
        }
    }
}

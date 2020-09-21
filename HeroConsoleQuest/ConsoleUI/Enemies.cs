using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Enemies
    {
        public string name;
        public int attack;
        public int defense;
        public int health;
        public int mana;

        public Enemies(string enemyName, int enemyAttack, int enemyDefense, int enemyHealth, int enemyMana)
        {
            name = enemyName;
            attack = enemyAttack;
            defense = enemyDefense;
            health = enemyHealth;
            mana = enemyMana;
        }

        public static void EnemyStats(string enemyName, int health)
        {
            Console.WriteLine(enemyName);
            Console.WriteLine(health);
        }

        public static void EnemyEncounter(string enemyName, int enemyHealth )
        {
            Color.Danger($"You have encountered a { enemyName }!");
            Console.WriteLine();
            Console.WriteLine($"Name: { enemyName }   Health: { enemyHealth }");

        }
    }
}

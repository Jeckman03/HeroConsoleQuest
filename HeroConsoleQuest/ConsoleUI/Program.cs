using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        //starting character stats
        public static string userHero = "Warrior";
        public static int defaultAttack = 10;
        public static int defaultDefence = 5;
        public static int userLevel = 1;
        public static int userHealth = 100;
        public static int userMana = 50;
        public static int userGold = 0;

        //to keep the game going or not
        public static bool playGame = true;

        static void Main(string[] args)
        {
            Menus.StartMenu();

            Characters player = new Characters(defaultAttack, defaultDefence, userLevel, userHealth, userMana, userGold);

            CharacterUI.CharacterInfoBar(userHero, player.level, player.health, player.mana, player.gold);

            do
            {
                Enemies goblin = new Enemies("Goblin", 8, 3, 20, 0);

                Enemies.EnemyEncounter(goblin.name, goblin.health);

                player.health = Attacks.EnemyAttack(goblin.attack, player.health, player.defend);

                playGame = EndGame.GameOver(player.health);

            } while (playGame == true);


            Console.ReadLine();
        }
    }
}

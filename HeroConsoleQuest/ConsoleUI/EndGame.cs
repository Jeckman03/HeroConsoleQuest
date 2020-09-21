using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class EndGame
    {
        public static bool GameOver(int playerHealth)
        {
            bool playGame = true;
            if (playerHealth <= 0)
            {
                Color.Danger("You have died. GAME OVER!");
                Console.ReadLine();
                playGame = false;
            }

            return playGame;
        }
    }
}

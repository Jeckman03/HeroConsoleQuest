using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class Menus
    {

        public static void StartMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
      _    _                   _____                      _         ____                  _   
     | |  | |                 / ____|                    | |       / __ \                | |  
     | |__| | ___ _ __ ___   | |     ___  _ __  ___  ___ | | ___  | |  | |_   _  ___  ___| |_ 
     |  __  |/ _ \ '__/ _ \  | |    / _ \| '_ \/ __|/ _ \| |/ _ \ | |  | | | | |/ _ \/ __| __|
     | |  | |  __/ | | (_) | | |___| (_) | | | \__ \ (_) | |  __/ | |__| | |_| |  __/\__ \ |_ 
     |_|  |_|\___|_|  \___/   \_____\___/|_| |_|___/\___/|_|\___|  \___\_\\__,_|\___||___/\__|
                                                                                          
                                                                                          ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("                                     PRESS ENTER TO BEGIN");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}

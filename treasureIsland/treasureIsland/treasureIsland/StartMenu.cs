using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treasureIsland
{
    class StartMenu
    {
        public static void startMenu()
        {
            bool loopContinue = true;
            while (loopContinue)
            {
                Console.Write("Would you like to play Treasure Island?(Yes/No): ");
                string input = (Console.ReadLine().ToLower());

                switch (input)
                {
                    case "yes":
                        Console.WriteLine("Let the game begin!");
                        PlayGame.playGame();
                        break;
                    case "no":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter yes or no.");
                        break;
                }

            }

        }
    }
}

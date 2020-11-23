using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace treasureIsland
{
    class treasureIsland
    {
        public static Description description = new Description();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to...\n\nTREASURE ISLAND!\n");
            startMenu();
        }
        //Methods
        public static void areaDescription(Player player)
        {
            Console.WriteLine(description.getDescription(player));
        }
        public static void startMenu()
        {
            Console.Write("Would you like to play Treasure Island?: ");
            string input = (Console.ReadLine().ToLower());
            if (input == "yes" || input == "y")
            {
                Console.WriteLine("Let the game begin!");
                playGame();

            }
            else if (input == "no" || input == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input.");
                startMenu();
            }
        }


        public static void playGame()
        {
            //Construct Objects to be found in the game
            Item bottle = new Item("Message in a Bottle", "An old glass bottle with a " +
                                    "faded piece of paper inside", 3, 0, false, false);
            Item sword = new Item("Rusted Scimitar", "A rusty scimitar that has jewels " +
                "                  embedded in it's hilt", 4, 4, false, false);
            Item chest = new Item("Treasue Chest", "An old wooden chest full to the " +
                "                  brim with treasure", 1, 3, false, false);
            Item[] Items = new Item[3];
            Items[0] = bottle;
            Items[1] = sword;
            Items[2] = chest;

            //Get players name and construct the player object
            Console.Write("What is your name?: ");
            string input = Console.ReadLine();

            //Randomly generate where the player starts on the Island
            Random random = new Random();
            int randomX = random.Next(0, 4);
            int randomY = random.Next(0, 4);

            //Create the player
            Player current = new Player(input, randomX, randomY, false);

            //Welcome player after creating the object
            Console.WriteLine("Hello " + current.getPlayerName());

            //Pause to let the player read the welcome then clear console to start
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            areaDescription(current);
            Console.Write("Which way would you like to go? (North, East, South, West): ");
            while (input != "quit" || checkWin(bottle, sword, chest))
            {
                input = (Console.ReadLine().ToLower());
                current.movement(input, current);
            }
        }

        public static bool checkWin(Item bottle, Item sword, Item chest)
        {
            if (bottle.getHasBeenCarried() && sword.getHasBeenCarried() && chest.getHasBeenCarried())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

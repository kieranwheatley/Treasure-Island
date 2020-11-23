using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treasureIsland
{
    class PlayGame
    {
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

            //Clear previous input
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

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
            Console.WriteLine("Hello " + current.getPlayerName() + " and welcome to the Island.");

            //Pause to let the player read the welcome then clear console to start
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            AreaDescription.areaDescription(current);
            while (input != "quit" || !sword.getHasBeenCarried() && !chest.getHasBeenCarried() && !bottle.getHasBeenCarried())
            {

                Console.Write("\n\nWhich way would you like to go? (North, East, South, West): ");
                input = (Console.ReadLine().ToLower());
                DropItem.dropItem(current, Items, input);
                current.movement(input, current, sword, bottle, chest);
                ItemCheck.itemCheck(current, sword);
                ItemCheck.itemCheck(current, bottle);
                ItemCheck.itemCheck(current, chest);
            }
        }
    }
}

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace treasureIsland
{
    class treasureIsland
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" \n\t Welcome to...\n\tTREASURE ISLAND!\n");
            startMenu();
        }
        //Methods
        public static void areaDescription()
        {
            
        }
        public static bool itemCheck(Player player, Item item, Item item2, Item item3)
        {
            bool itemFound;
            if (player.getPlayerX() == item.getItemX() && player.getPlayerY() == item.getItemY())
            {
                Console.WriteLine("You have found '" + item.getItemName() + "'. " + item.getItemDescription() + ".");
                itemFound = true;
                return itemFound;
            }
            else
            {
                itemFound = false;
                return itemFound;
            }
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
            //Get players name and construct the player object
            Console.Write("What is your name?: ");
            string input = Console.ReadLine();
            Player current = new Player(input, 2, 2, false);

            //Welcome player after creating the object
            Console.WriteLine("Hello " + current.getPlayerName());

            //Pause to let the player read the welcome then clear console to start
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.Write("You find yourself stood in a jungle, surrounded by trees. You can hear " +
                "birds chirping from the trees.\nWhich way would you like to go? (North, East, South, West): ");
            while (input != "quit" || bottle.getHasBeenCarried() != "false" && sword.getHasBeenCarried() != "false" && chest.getHasBeenCarried() != "false")
            {
                input = (Console.ReadLine().ToLower());
                //Movement --- Add parameter passing to a method
                if (input == "north" || input == "n")
                {
                    if (current.getPlayerX() > 0)
                    {
                        Console.WriteLine("You move North.");
                        current.setPlayerX(current.getPlayerX() - 1);
                        areaDescription();
                        itemCheck(current, bottle, sword, chest);
                    }
                    else
                    {
                        Console.WriteLine("You cannot move further North!");
                    }
                }
                else if (input == "south" || input == "s")
                {
                    if (current.getPlayerX() < 4)
                    {
                        Console.WriteLine("You move South.");
                        current.setPlayerX(current.getPlayerX() + 1);
                        areaDescription();
                        itemCheck(current, bottle, sword, chest);
                    }
                    else
                    {
                        Console.WriteLine("You cannot move further South!");
                    }
                }
                else if (input == "east" || input == "e")
                {
                    if (current.getPlayerY() < 4)
                    {
                        Console.WriteLine("You move East.");
                        current.setPlayerY(current.getPlayerY() + 1);
                        areaDescription();
                        itemCheck(current, bottle, sword, chest);
                    }
                    else
                    {
                        Console.WriteLine("You cannot move further East!");
                    }
                }
                else if (input == "west" || input == "w")
                {
                    if (current.getPlayerY() > 0)
                    {
                        Console.WriteLine("You move West.");
                        current.setPlayerY(current.getPlayerY() - 1);
                        areaDescription();
                        itemCheck(current, bottle, sword, chest);
                    }
                    else
                    {
                        Console.WriteLine("You cannot move further West!");
                    }
                }
                else if (input == "quit")
                {
                    Console.Clear();
                    Console.WriteLine("You have failed to find all the items and left the Island.\nOne day you may return to try again...");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    startMenu();
                }

            }
        }
    }
}

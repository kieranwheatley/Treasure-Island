using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace treasureIsland
{
    class PlayGame
    {
        public static void playGame()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoice("Microsoft Zira Desktop");

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
            string askName = "What is your name?: ";
            Console.Write(askName);
            synth.Speak(askName);
            string input = Console.ReadLine();
            //Randomly generate where the player starts on the Island
            Random random = new Random();
            int randomX = random.Next(0, 4);
            int randomY = random.Next(0, 4);

            //Create the player
            Player current = new Player(input, randomX, randomY, false);

            //Welcome player after creating the object
            string welcomePlayer = ("Hello " + current.getPlayerName() + " and welcome to the Island.");
            Console.WriteLine(welcomePlayer);
            synth.Speak(welcomePlayer);

            //Run through controls
            synth.Rate = 2;
            string controls = ("\nTo move, enter either: \nNorth\nSouth\nEast\nWest\nor use the first letter of each to move.\n\nIf you wish to exit the game, type 'quit' and the game will end.\n\nWhen you find an item, you will be prompted whether or not to collect it using 'yes' or 'no.'\n\nIf you are carrying an item and wish to drop it, type 'drop' and it will be placed where you are.");
            Console.WriteLine(controls);
            synth.Speak(controls);


            //Pause to let the player read the welcome then clear console to start
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            AreaDescription.areaDescription(current);
            while (input != "quit" || !sword.getHasBeenCarried() && !chest.getHasBeenCarried() && !bottle.getHasBeenCarried())
            {
                string move = "Which way would you like to go?: ";

                Console.WriteLine("\n\n");
                Console.Write(move);
                synth.Speak(move);
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

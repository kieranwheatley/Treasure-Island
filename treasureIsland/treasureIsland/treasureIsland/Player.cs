using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
namespace treasureIsland
{

    class Player
    {
        

        //Variables
        private string name;
        private int x, y;
        private bool isCarrying;
        //Constructor(s)
        public Player(string inName, int startX, int startY, bool startIsCarrying)
        {
            name = inName;
            x = startX;
            y = startY;
            isCarrying = startIsCarrying;
        }
        //Getters
        public string getPlayerName()
        {
            return name;
        }
        public int getPlayerX()
        {
            return x;
        }
        public int getPlayerY()
        {
            return y;
        }
        public bool getIsCarrying()
        {
            return isCarrying;
        }
        //Setters
        public void setPlayerName(string inName)
        {
            name = inName;
        }
        public void setPlayerX(int inX)
        {
            x = inX;
        }
        public void setPlayerY(int inY)
        {
            y = inY;
        }
        public void setIsCarrying(bool inIsCarrying)
        {
            isCarrying = inIsCarrying;
        }


        //Methods
        public void movement(String userInput, Player player, Item item, Item item2, Item item3)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoice("Microsoft Zira Desktop");

            string input = userInput;
            //Movement --- Add parameter passing to a method
            if (input == "north" || input == "n")
            {
                if (player.getPlayerY() > 0)
                {
                    Console.WriteLine("You move North.");
                    synth.Speak("You move North.");
                    player.setPlayerY(player.getPlayerY() - 1);
                    AreaDescription.areaDescription(player);
                }
                else
                {
                    Console.WriteLine("You cannot move further North!");
                    synth.Speak("You cannot move further North.");
                }
            }
            else if (input == "south" || input == "s")
            {
                if (player.getPlayerY() < 4)
                {
                    Console.WriteLine("You move South.");
                    synth.Speak("You move South.");

                    player.setPlayerY(player.getPlayerY() + 1);
                    AreaDescription.areaDescription(player);
                }
                else
                {
                    Console.WriteLine("You cannot move further South!");
                    synth.Speak("You cannot move further South.");
                }
            }
            else if (input == "east" || input == "e")
            {
                if (player.getPlayerX() < 4)
                {
                    Console.WriteLine("You move East.");
                    synth.Speak("You move East.");
                    player.setPlayerX(player.getPlayerX() + 1);
                    AreaDescription.areaDescription(player);
                }
                else
                {
                    Console.WriteLine("You cannot move further East!");
                    synth.Speak("You cannot move further East.");
                }
            }
            else if (input == "west" || input == "w")
            {
                if (player.getPlayerX() > 0)
                {
                    Console.WriteLine("You move West.");
                    synth.Speak("You move West.");
                    player.setPlayerX(player.getPlayerX() - 1);
                    AreaDescription.areaDescription(player);
                }
                else
                {
                    Console.WriteLine("You cannot move further West!");
                    synth.Speak("You cannot move further West.");
                }
            }
            else if (input == "quit")
            {
                Console.Clear();
                Console.WriteLine("You have failed to find all the items and left the Island.\nOne day you may return to try again...");
                synth.Speak("You have failed to find all the items and left the Island. One day you may return to try again...");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                StartMenu.startMenu();
            }
            else if (item.getHasBeenCarried() && item2.getHasBeenCarried() && item3.getHasBeenCarried())
            {
                Console.Clear();
                Console.WriteLine("Congratulations! You found all the objects on the map and have completed Treasure Island!\n\nPress any key to exit the game.");
                synth.Speak("Congratulations! You found all the object on the map and have completed Treasure Island! Press any key to exit the game.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}

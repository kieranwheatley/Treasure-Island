using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace treasureIsland
{
    class StartMenu
    {
        public static void startMenu()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoice("Microsoft Zira Desktop");
            bool loopContinue = true;
            while (loopContinue)
            {
                string play = "Would you like to play? (Yes | No): ";
                Console.Write(play);
                synth.Speak(play);
                string input = (Console.ReadLine().ToLower());

                string yes = "Let the game begin!";
                string invalid = "Invalid input. Please enter yes or no.";

                switch (input)
                {
                    case "yes":
                        Console.WriteLine(yes);
                        synth.Speak(yes);
                        PlayGame.playGame();
                        break;
                    case "no":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(invalid);
                        synth.Speak(invalid);
                        break;
                }

            }

        }
    }
}

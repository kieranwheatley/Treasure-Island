using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace treasureIsland
{
    class treasureIsland
    {
        
        public static Description description = new Description();
        
        static void Main(string[] args)
        {
            string welcome = "Welcome to... Treasure Island!";
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoice("Microsoft Zira Desktop");
            Console.WriteLine("Welcome to...\n\nTREASURE ISLAND!\n");
            synth.Speak(welcome);
            StartMenu.startMenu();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
namespace treasureIsland
{
    class AreaDescription
    {
        public static void areaDescription(Player player)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoice("Microsoft Zira Desktop");
            synth.Rate = 2;

            Description description = new Description();
            Console.WriteLine(description.getDescription(player));
            synth.Speak(description.getDescription(player));

        }
    }
}

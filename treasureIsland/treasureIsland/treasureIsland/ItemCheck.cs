using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace treasureIsland
{
    class ItemCheck
    {

        public static void itemCheck(Player player, Item item)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoice("Microsoft Zira Desktop");

            if (player.getPlayerX() == item.getItemX() && player.getPlayerY() == item.getItemY() && !player.getIsCarrying())
            {
                string found = "\nYou have found " + item.getItemName() + ". Would you like to pick it up?: ";
                Console.Write("\n\n" + found);
                synth.Speak(found);
                string pickup = Console.ReadLine().ToLower();
                switch (pickup)
                {
                    case "yes":
                        PickupItem.pickupItem(player, item);
                        break;
                    case "no":
                        string dontPickup = "You leave the " + item.getItemName() + " where it is and carry on exploring.";
                        Console.WriteLine(dontPickup);
                        synth.Speak(dontPickup);
                        break;
                    default:
                        string invalid = "Invalid input. Please enter Yes to pickup item or No to leave it.";
                        Console.WriteLine(invalid);
                        synth.Speak(invalid);
                        break;
                }
                return;
            }
            else if (player.getPlayerX() == item.getItemX() && player.getPlayerY() == item.getItemY() && player.getIsCarrying())
            {
                string alreadyCarrying = "You find a " + item.getItemName() + " but as you are already carrying an object you cannot take another. Drop the one you have elsewhere and return for this.";
                Console.WriteLine(alreadyCarrying);
                synth.Speak(alreadyCarrying);
                return;
            }
            else
            {
                return;
            }
        }
    }
}

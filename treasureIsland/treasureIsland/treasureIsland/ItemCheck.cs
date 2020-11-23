using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treasureIsland
{
    class ItemCheck
    {
        public static void itemCheck(Player player, Item item)
        {
            if (player.getPlayerX() == item.getItemX() && player.getPlayerY() == item.getItemY() && !player.getIsCarrying())
            {
                Console.Write("\nYou have found " + item.getItemName() + ". Would you like to pick it up?: ");
                string pickup = Console.ReadLine().ToLower();
                switch (pickup)
                {
                    case "yes":
                        PickupItem.pickupItem(player, item);
                        break;
                    case "no":
                        Console.WriteLine("You leave the " + item.getItemName() + " where it is and carry on exploring.");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter Yes to pickup item or No to leave it.");
                        break;
                }
                return;
            }
            else if (player.getPlayerX() == item.getItemX() && player.getPlayerY() == item.getItemY() && player.getIsCarrying())
            {
                Console.WriteLine("You find a " + item.getItemName() + " but as you are already carrying an object you cannot take another. Drop the one you have elsewhere and return for this.");
                return;
            }
            else
            {
                return;
            }
        }
    }
}

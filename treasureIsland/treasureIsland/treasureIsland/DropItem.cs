using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treasureIsland
{
    class DropItem
    {
        public static void dropItem(Player player, Item[] items, String input)
        {
            if (input.ToLower() == "drop")
            {
                foreach (Item item in items)
                {
                    if (item.getIsBeingCarried())
                    {
                        //Sets the items coordinates to where the player is, as that becomes it's new location
                        item.setItemX(player.getPlayerX());
                        item.setItemY(player.getPlayerY());
                        player.setIsCarrying(false);
                        item.setHasBeenCarried(true);
                        item.setIsBeingCarried(false);
                        return;
                    }
                }
                return;
            }
            return;
        }
    }
}


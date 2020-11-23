using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treasureIsland
{
    class PickupItem
    {
        public static void pickupItem(Player player, Item item)
        {
            item.setIsBeingCarried(true);
            //Sets the items coordinates to 5 as that is out of player movement radius (so they cannot find the object whilst carrying)
            item.setItemX(5);
            item.setItemY(5);
            player.setIsCarrying(true);
            return;
        }
    }
}

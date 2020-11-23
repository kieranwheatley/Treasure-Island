using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treasureIsland
{
    class AreaDescription
    {
        public static void areaDescription(Player player)
        {
            Description description = new Description();
            Console.WriteLine(description.getDescription(player));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace treasureIsland
{
    class treasureIsland
    {
        public static Description description = new Description();
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to...\n\nTREASURE ISLAND!\n");
            StartMenu.startMenu();
        }
    }
}

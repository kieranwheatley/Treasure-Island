using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string getIsCarrying()
        {
            return Convert.ToString(isCarrying);
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
    }
}

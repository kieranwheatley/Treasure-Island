using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treasureIsland
{
    class Item
    {
        //Variables
        private string name, description;
        private int x, y;
        private bool isBeingCarried, hasBeenCarried;
        //Constructors
        public Item(string inItemName, string inDescription, int inX, int InY, bool inIsBeingCarried, bool inHasBeenCarried)
        {
            name = inItemName;
            description = inDescription;
            x = inX;
            y = InY;
            isBeingCarried = inIsBeingCarried;
            hasBeenCarried = inHasBeenCarried;
        }
        //Getters
        public string getItemName()
        {
            return name;
        }
        public string getItemDescription()
        {
            return description;
        }
        public int getItemX()
        {
            return x;
        }
        public int getItemY()
        {
            return y;
        }
        public string getIsBeingCarried()
        {
            return Convert.ToString(isBeingCarried);
        }
        public bool getHasBeenCarried()
        {
            return hasBeenCarried;
        }
        //Setters
        public void setItemName(string inItemName)
        {
            name = inItemName;
        }
        public void setItemDescription(string inItemDescription)
        {
            description = inItemDescription;
        }
        public void setItemX(int inX)
        {
            x = inX;
        }
        public void setItemY(int inY)
        {
            y = inY;
        }
        public void setIsBeingCarried(bool inBeingCarried)
        {
            isBeingCarried = inBeingCarried;
        }
        public void setHasBeenCarried(bool inBeenCarried)
        {
            hasBeenCarried = inBeenCarried;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    class Pirate
    {
        int rumShot = 0;
        bool isAlive = true;
        bool passOut = false;
        string name;

        public Pirate(int rumShot, bool isAlive, bool passOut, string name)
        {
            this.rumShot = rumShot;
            this.isAlive = isAlive;
            this.passOut = passOut;
            this.name = name;
        }

        public int DrinkSomeRum()
        {
            rumShot ++;
            return rumShot;
        }

        public string HowsItGoingMate()
        {
            if (!isAlive)
            {
                return "he is dead";
            }
            else if ( rumShot <= 4)
            {
                return "Pour me anudder";
            }
            else
            {
                return "Arghh, I am a Pirate. How d'ya d'ink its going?";
            }
        }

        public bool PassOut()
        {
            if (passOut)
            {
                return true;
            }
            return true;
        }

        public bool Die()
        {
            if (isAlive)
            {
                return true;
            }
            return true;
        }

        public string PrintOutPirates()
        {
            return "The toxicitylevel is: " + DrinkSomeRum() + " is he awake? " + PassOut() + "he is dead from drinking too much " + Die();
        }
    }
}

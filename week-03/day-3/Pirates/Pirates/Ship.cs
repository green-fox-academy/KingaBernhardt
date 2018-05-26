using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    class Ship
    {
        public List<Pirate> crew = new List<Pirate>();
        public Random randomValue = new Random();
        Pirate captain = new Pirate(18, false, true, "Miki");

        public void FillShip()
        {
            for (int i = 0; i < randomValue.Next(0,14); i++)
            {
                crew.Add(new Pirate(1, true, false, "Mary"));
                crew.Add(new Pirate(6,true, false, "Boby"));
                crew.Add(new Pirate(12, true, true, "Mandy"));
                crew.Add(new Pirate(4, true, false, "Ciw"));
            }
        }
        public string GetShipStatus()
        {
            return "Our captain's passed out: " + captain.PassOut() + " or is he still alive: " + captain.Die() + " and he drunk how much: " + captain.DrinkSomeRum();
        }
        public int MembersAlive()
        {
            int dieCounter = 0;
           
            foreach (var pirate in crew)
                if (pirate.Die())
                {
                    return dieCounter++;
                }
            return dieCounter;
        }
        public int MembersPassedOut()
        {
            int passOutCounter = 0;
            foreach (var pirate in crew)
            {
                if (pirate.PassOut())
                {
                    return passOutCounter++;
                }
            }
            return passOutCounter;
        }
    }
}

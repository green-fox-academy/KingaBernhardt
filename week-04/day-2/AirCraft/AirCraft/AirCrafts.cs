using System;
using System.Collections.Generic;
using System.Text;

namespace AirCraft
{
    public class AirCrafts
    {
        private string type;
        private int ammo = 0;
        private int baseDamage;

        public int Fights()
        {
            int ammo = 0;
            int allDamage = baseDamage + ammo;
            return allDamage;
        }

        public int Refill(int givenNum)
        {
            int remainAmmo = givenNum - ammo;
            return remainAmmo;
        }
    }
}

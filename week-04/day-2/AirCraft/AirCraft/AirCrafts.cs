using System;
using System.Collections.Generic;
using System.Text;

namespace AirCraft
{
    public class AirCrafts
    {
        private string type;
        private int ammo;
        private int baseDamage;

        public virtual int Fights()
        {
            int ammo = 0;
            int allDamage = baseDamage + ammo;
            return allDamage;
        }

        public virtual int Refill(int givenNum)
        {
            int remainAmmo = givenNum - ammo;
            return remainAmmo;
        }

        public virtual string GetType()
        {
            return type;
        }

        public virtual string GetStatus()
        {
            return "Type " + GetType() + ", Ammo: " + ammo + " Base Damage: " + baseDamage + " All Damage: " + Fights();
        }
    }
}

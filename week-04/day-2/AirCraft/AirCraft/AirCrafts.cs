using System;
using System.Collections.Generic;
using System.Text;

namespace AirCraft
{
    public class AirCraft
    {
        private int Ammo { get; set; }
        private int MaxAmmo { get; set; }
        private int Damage { get; set; }

        public AirCraft(int ammo, int damage)
        {
            Ammo = 0;
            MaxAmmo = ammo;
            Damage = damage;
        }

        public int Fights()
        {
            int ammoToDeplete = Ammo;
            Ammo = 0;
            return ammoToDeplete * Damage;
        }

        public int Refill(int ammoAmountToFill)
        {
            if (MaxAmmo - Ammo <= ammoAmountToFill)
            {
                Ammo += MaxAmmo - Ammo;
                return 0;
            }
            else
            {
                int remainingAmmo = MaxAmmo - Ammo;
                Ammo = MaxAmmo;
                return ammoAmountToFill - remainingAmmo;
            }
        }

        public new string GetType()
        {
            if (this is F16)
            {
                return "F16";
            }
            else
            {
                return "F35";
            }
        }

        public bool IsPriority()
        {
            return this is F35;
        }
        public string GetStatus()
        {
            return "Type " + GetType() + ", Ammo: " + Ammo + " Base Damage: " + Damage + " All Damage: " + Ammo * Damage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AirCraft
{
    class Carrier :AirCrafts
    {
        List<AirCrafts> carrier;
        private int storeOfAircraft;
        private int storeOfAmmo;
        private int healthPoint;

        public Carrier(int storeOfAmmo, int healthPoint)
        {
            this.storeOfAmmo = storeOfAmmo;
            this.healthPoint = healthPoint;

            List<AirCrafts> carrier = new List<AirCrafts>();
        }

        public int AddAirCraft(AirCrafts helicopter)
        {
           carrier.Add(helicopter);
           return storeOfAircraft++; 
        }

        public void FillAirCraft()
        {
            try
            {
                for (int i = 0; i < carrier.Count; i++)
                {
                    if (carrier[i].IsPriority())
                    {
                        storeOfAmmo = carrier[i].Refill(storeOfAmmo);
                    }
                }
                
            }
            catch (MissingMemberException)
            {

                throw;
            }
        }

        public string Fight(Carrier otherCarrier)
        {
            string output = String.Empty;

            FillAirCraft();

            for (int i = 0; i < carrier.Count; i++)
            {
                otherCarrier.healthPoint -= carrier[i].Fights();
            }
            return output += otherCarrier.GetStatus();
        }

        public int GetTotalDamage()
        {
            int damage = 0;
            for (int i = 0; i < carrier.Count; i++)
            {
                damage += carrier[i].Fights();
            }
            return damage;
        }
        public string GetStatus()
        {
            string output;
            if (healthPoint > 0)
            {
                output = $"HP: {healthPoint}, Aircraft count: {carrier.Count}, Ammo Storage: {storeOfAmmo}, " +
                                    $"Total Damage: {GetTotalDamage()}\nAircrafts: \n";
                for (int i = 0; i < carrier.Count; i++)
                {
                    output += carrier[i].GetStatus() + "\n";
                }
                return output;
            }
            else
            {
                return "It's Dead Jim";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AirCraft
{
    public class Carrier
    {
        private List<AirCraft> carrier;
        private int storeOfAmmo;
        private int healthPoint;

        public Carrier(int storeOfAmmo, int healthPoint)
        {
            this.storeOfAmmo = storeOfAmmo;
            this.healthPoint = healthPoint;

            this.carrier = new List<AirCraft>();
        }

        public void Add(AirCraft aeroplane)
        {
            carrier.Add(aeroplane);
        }

        public void FillAirCraft()
        {
            if (storeOfAmmo == 0)
            {
                throw new Exception("Give me ammo");
            }
            foreach (AirCraft oneCarrier in carrier)
            {
                if (oneCarrier.IsPriority())
                {
                    storeOfAmmo = oneCarrier.Refill(storeOfAmmo);
                }
            }
        }
        public void Fight(Carrier otherCarrier)
        {
            int totalDamage = 0;
            foreach (AirCraft oneCarrier in carrier)
            {
                totalDamage += oneCarrier.Fights();
            }
            otherCarrier.healthPoint -= totalDamage;
            if (otherCarrier.healthPoint < 0)
            {
                otherCarrier.healthPoint = 0;
            }
        }

        public string GetStatus()
        {
            if (healthPoint != 0)
            {
                int totalDamage = 0;
                foreach (AirCraft oneCarrier in carrier)
                {
                    totalDamage += oneCarrier.Fights();

                }
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(
                    String.Format("HP: {0}, Aircraft count: {1}, Ammo Storage: {2}, Total damage: {3}\nAircrafts:\n",
                    healthPoint, carrier.Count, storeOfAmmo, totalDamage));

                foreach (AirCraft oneCarrier in carrier)
                {
                    stringBuilder.Append(oneCarrier.GetStatus()).Append("\n");
                }
                return stringBuilder.ToString();
            }
            else
            {
                return "It's dead Jim :(";
            }
        }
    }
}

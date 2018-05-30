using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApplication
{
    class Plant
    {
        protected string color;
        protected double waterAmount;
        private double waterAbsorb;

        public double WaterAbsorb
        {
            get
            {
                return waterAbsorb;
            }
            set
            {
                waterAbsorb = value;
            }
        }

        public double WaterAmount
        {
            get
            {
                return waterAmount;
            }
        }

        public void SetCurrentWaterAmount(double change)
        {
            waterAmount += change;
        }

        public Plant(string color)
        {
            this.color = color;
            waterAmount = 0;
        }

        public virtual string NeedWater()
        {
            return "Override in subclass";
        }

        public virtual double WaterAbsorbtion(double gotWatered)
        {
            return WaterAbsorb;
        }
    }
}

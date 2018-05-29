using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApplication
{
    class Plant
    {
        protected string color;
        private double waterAmount;
        private double waterAbsorb;

        public double WaterAbsorb
        {
            get
            {
                return waterAbsorb;
            }
            set
            {

            }
        }

        public double WaterAmount
        {
            get
            {
                return waterAmount;
            }
            set
            {

            }
        }

        public Plant(string color)
        {
            this.color = color;
            waterAmount = 0;
        }
    }
}

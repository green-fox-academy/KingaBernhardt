using System;
using System.Collections.Generic;
using System.Drawing;
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
        
        public Plant(Color color)
        {
            this.color = color;
            waterAmount = 0;
        }
        public string NeedsWater()
        {
            return "The " + color + "needs water.";
        }
    }
}

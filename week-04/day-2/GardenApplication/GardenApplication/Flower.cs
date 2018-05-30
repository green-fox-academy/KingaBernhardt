using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GardenApplication
{
    class Flower : Plant
    {
        public Flower(string color) : base(color)
        {
        }

        public override double WaterAbsorbtion(double gotWatered)
        {
            WaterAbsorb = gotWatered * 0.75;
            return WaterAbsorb;
        }

        public override string NeedWater()
        {
            if (WaterAmount >= 5)
            {
                return "The " + color + " Flower does not need water.";
            }
            else
            {
                return "The " + color + " Flower needs water.";
            }
        }
    }
}

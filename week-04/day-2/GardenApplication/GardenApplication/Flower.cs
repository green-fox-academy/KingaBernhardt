using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GardenApplication
{
    class Flower : Plant
    {
        public Flower(Color color) : base(color)
        {
            WaterAbsorb = 0.75;
        }
        public override string ToString()
        {
            if (WaterAmount >= 5)
            {
                return color + " Flower does not need water.";
            }
            else
            {
                return color + " Flower needs water.";
            }
            
        }
    }
}

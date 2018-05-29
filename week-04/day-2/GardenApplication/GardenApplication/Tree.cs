using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GardenApplication
{
    class Tree : Plant
    {
        public Tree(string color) : base(color)
        {
            WaterAbsorb = 0.4;
        }
        public override string ToString()
        {
            if (WaterAmount >= 10)
            {
                return "The " + color + " Tree doesn't need water.";
            }
            else
            {
                return "The " + color + " Tree needs water.";
            }
           
        }

    }
}

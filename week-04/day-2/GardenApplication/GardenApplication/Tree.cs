using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GardenApplication
{
    class Tree : Plant
    {
        public Tree(Color color) : base(color)
        {
            WaterAbsorb = 0.4;
        }
        public override string ToString()
        {
            if (WaterAmount >= 10)
            {
                return color + " Tree doesn't need water.";
            }
            else
            {
                return color + " Tree needs water.";
            }
           
        }

    }
}

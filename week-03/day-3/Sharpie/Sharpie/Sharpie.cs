using System;
using System.Collections.Generic;
using System.Text;

namespace Sharpie
{
    class Sharpie
    {
        public string color;
        public float width;
        public float inkAmount;

        public Sharpie(float inkAmount)
        {
            color = "Brown";
            width = 1.7f;
            this.inkAmount = inkAmount;
        }

        public Sharpie(string color, float width)
        {
            this.color = color;
            this.width = width;
            inkAmount = 100;
        }
        public float Use(float decreaseAmount)
        {
            inkAmount -= decreaseAmount;
            return inkAmount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Flyable
{
    public abstract class Vehicle
    {
        protected int age;
        protected string color;
        protected int speedUp;

        public Vehicle(int age, string color, int speedUp)
        {
            this.age = age;
            this.color = color;
            this.speedUp = speedUp;
        }
    }
}

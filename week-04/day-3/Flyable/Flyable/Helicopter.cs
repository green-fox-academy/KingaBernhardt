using System;
using System.Collections.Generic;
using System.Text;

namespace Flyable
{
    class Helicopter : Vehicle, IFlyable
    {
        public Helicopter(int age, string color, int speedUp) : base(age, color, speedUp)
        {
        }

        public void Fly()
        {
            if (speedUp > 200)
            {
                Console.WriteLine("The " + color + "helicopter is flying 1000 meters high.");
            }
            else
            {
                Console.WriteLine("The " + color + " helicopter is flying low.");
            }
        }

        public void Land()
        {
            if (speedUp < 80)
            {
                Console.WriteLine("The " + color + " helicopter is about to land.");
            }
            else
            {
                Console.WriteLine("The " + color + " helicopter is still flying");
            }
        }

        public void TakeOff()
        {
            if (age > 15)
            {
                Console.WriteLine("The " + color + " helicopter is " + age + " years old " + "so it can not take of anymore.");
            }
            else
            {
                Console.WriteLine("The " + color + " helicopter is " + age + " years old " + " so it can still take of anytime.");
            }
        }
    }
}

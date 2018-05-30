using System;
using System.Collections.Generic;
using System.Text;

namespace Flyable
{
    class Bird : Animal, IFlyable
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        public void Fly()
        {
            Console.WriteLine(name + " is flying.");
        }

        public void Land()
        {
            Console.WriteLine(name + " lives in Europe.");
        }

        public void TakeOff()
        {
            Console.WriteLine(name + " take off when it is Autumn.");
        }

        public override string WantChild()
        {
            return name + " is " + age + " so it wants a child now.";
        }
    }
}

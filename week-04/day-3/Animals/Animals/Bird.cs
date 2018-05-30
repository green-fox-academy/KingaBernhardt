using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        public override string WantChild()
        {
            return "want a child from an egg";
        }
    }
}

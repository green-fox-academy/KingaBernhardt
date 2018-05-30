using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Reptile : Animal
    {
        public Reptile(string name, int age) : base(name, age)
        {
        }

        public override string WantChild()
        {
            return "want child from an egg";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Mammal : Animal
    {
        public Mammal(string name, int age) : base(name, age)
        {
        }

        public override string WantChild()
        {
            return "want child from my uterus";
        }
    }
}

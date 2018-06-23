using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Lion : Animal
    {
        public Lion(string name) : base(name)
        {
        }

        public Lion(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override bool isHungry()
        {
            return true;
        }
    }
}

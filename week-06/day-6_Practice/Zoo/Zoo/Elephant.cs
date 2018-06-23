using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Elephant : Animal
    {
        public Elephant(string name) : base(name)
        {
        }

        public Elephant(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override bool isHungry()
        {
            bool a = false;
            if (a == false)
            {
                a = true;
            }
            else
            {
                a = false;
            }
            return a; 
        }
    }
}

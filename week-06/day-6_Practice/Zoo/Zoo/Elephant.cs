using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Elephant : Animal
    {
        private int counter = 0;

        public Elephant(string name) : base(name)
        {
        }

        public Elephant(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override bool isHungry()
        {
            counter++;

            if (counter % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Monkey : Animal
    {
        public Monkey(string name) : base(name)
        {
        }

        public override bool isHungry()
        {
            Random rnd = new Random();
            int prob = rnd.Next(100);
            return prob <= 20;
        }
    }
}

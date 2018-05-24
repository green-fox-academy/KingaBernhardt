using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    class Animal
    {
        public int hunger = 50;
        public int thirst = 50;
        
        public int GetHunger()
        {
            return hunger;
        }

        public int GetThirst()
        {
            return thirst;
        }

        public void Eat()
        {
            hunger--;
        }

        public void Drink()
        {
            thirst--;
        }

        public void Play()
        {
            hunger++;
            thirst++;
        }
    }
}

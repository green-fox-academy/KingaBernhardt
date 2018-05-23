using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Animal
    {
        public int hunger = 50;
        public int thirst = 50;
        public int[] thirstAndPlay = { 50, 50 };

        public int Eat()
        {
            hunger--;
            return hunger;
        }
        public int Drink()
        {
            thirst--;
            return thirst;
        }
        public int[] Play()
        {
            for (int i = 0; i < thirstAndPlay.Length; i++)
            {
                thirstAndPlay[i]++;
            }
            return thirstAndPlay;
        }
    }
}

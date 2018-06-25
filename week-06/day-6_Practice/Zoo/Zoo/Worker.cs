using System;
using System.Collections.Generic;

namespace Zoo
{
    internal class Worker
    {
        private string name;
        private List<Animal> animalsToLookAfter;

        internal List<Animal> AnimalsToLookAfter { get => animalsToLookAfter; set => animalsToLookAfter = value; }

        public Worker(string name, List<Animal> animalsToLookAfter)
        {
            this.name = name;
            this.animalsToLookAfter = animalsToLookAfter;
        }

        public Worker(string name)
        {
            this.name = name;
            animalsToLookAfter = new List<Animal>();
        }

        internal void DoDailyRoutine()
        {
            for (int i = 0; i < animalsToLookAfter.Count; i++)
            {
                if (animalsToLookAfter[i].isHungry())
                {
                    animalsToLookAfter[i].Eat();
                };
            } 
        }

        public void SetAnimalsToLookAfter(List<Animal> animal)
        {
            foreach (Animal item in animal)
            {
                animalsToLookAfter.Add(item);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    class Farm
    {
        List<Animal> farmAnimals = new List<Animal>();
        private int slots;
        public Farm(int slots)
        {
            this.slots = slots;
        }
        public void Breed()
        {
            if (farmAnimals.Count < slots)
            {
                farmAnimals.Add(new Animal());
            }
        }
        public void Slaughter()
        {
            int leastHungry = 0;
            for (int i = 0; i < farmAnimals.Count; i++)
            {
                if (farmAnimals[leastHungry].GetHunger() > farmAnimals[i].GetHunger())
                {
                    leastHungry = i;
                }
            }
            farmAnimals.RemoveAt(leastHungry);
        }
        public int GetAnimalIndexHunger()
        {
            return farmAnimals[0].GetHunger();
        }
    }
}

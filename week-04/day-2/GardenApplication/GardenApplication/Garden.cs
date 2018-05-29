using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApplication
{
    class Garden
    {
        List<Plant> plants = new List<Plant>();
        public List<Plant> Plant
        {
            get
            {
                return plants;
            }
        }
        public void AddTree(Tree tree)
        {
            plants.Add(tree);
        }
        public void AddFlower(Flower flower)
        {
            plants.Add(flower);
        }


    }
}

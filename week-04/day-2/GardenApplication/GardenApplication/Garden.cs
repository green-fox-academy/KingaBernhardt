using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApplication
{
    class Garden
    {
        List<Plant> plants = new List<Plant>();
        private double waterAmount;

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
        public string WaterPlant(double WaterAmount)
        {

            return "Watering with: " + WaterAmount;
        }
        public void WaterWith()
        {
                double waterPerPlant = waterAmount / plants.Count;
                if (plants.Count > 0)
                {
                    for (int i = 0; i < plants.Count; i++)
                    {
                        plants[i].WaterAmount += waterPerPlant * plants[i].WaterAbsorb;
                    }

                }
        }
    }
}

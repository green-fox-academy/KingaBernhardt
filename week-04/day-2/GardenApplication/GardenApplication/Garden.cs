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

        public string WaterPlant(double WaterAmount)
        {

            return "Watering with: " + WaterAmount;
        }

        public string ThroughMyGarden()
        {
            string output = "";
            for (int i = 0; i < plants.Count; i++)
            {
                output += plants[i].NeedWater();
                if (i < plants.Count - 1)
                {
                    output += "\n";
                }
            }
            return output;
        }

        public void Watering(int waterAmount)
        {
            double waterPerPlant = waterAmount / plants.Count;

            for (int i = 0; i < plants.Count; i++)
            {
                plants[i].SetCurrentWaterAmount(plants[i].WaterAbsorbtion(waterPerPlant));
            }
        }
    }
}

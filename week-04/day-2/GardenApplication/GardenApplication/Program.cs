using System;

namespace GardenApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden myLittleGarden = new Garden();
            Flower yellowFlower = new Flower("yellow");
            Flower blueFlower = new Flower("blue");
            Tree purpleTree = new Tree("purple");
            Tree orangeTree = new Tree("orange");
            myLittleGarden.Plant.Add(yellowFlower);
            myLittleGarden.Plant.Add(blueFlower);
            myLittleGarden.Plant.Add(purpleTree);
            myLittleGarden.Plant.Add(orangeTree);
            
            Console.WriteLine(yellowFlower.NeedWater());
            Console.WriteLine(blueFlower.NeedWater());
            Console.WriteLine(purpleTree.NeedWater());
            Console.WriteLine(orangeTree.NeedWater());
            Console.WriteLine(myLittleGarden.WaterPlant(40));
            myLittleGarden.Watering(40);
            Console.WriteLine(myLittleGarden.ThroughMyGarden());
            Console.WriteLine(myLittleGarden.WaterPlant(70));
            myLittleGarden.Watering(70);
            Console.WriteLine(myLittleGarden.ThroughMyGarden());

            Console.ReadLine();
        }
    }
}

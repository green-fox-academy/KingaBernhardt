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

            Console.WriteLine(yellowFlower.ToString());
            Console.WriteLine(blueFlower.ToString());
            Console.WriteLine(purpleTree.ToString());
            Console.WriteLine(orangeTree.ToString());
            Console.WriteLine(myLittleGarden.WaterPlant(40));
            myLittleGarden.WaterWith();
            Console.WriteLine(blueFlower.ToString());
            Console.WriteLine(purpleTree.ToString());
            Console.WriteLine(orangeTree.ToString());

            Console.ReadLine();
        }
    }
}

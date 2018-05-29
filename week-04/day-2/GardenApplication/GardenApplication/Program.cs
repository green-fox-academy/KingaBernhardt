using System;

namespace GardenApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden myLittleGarden = new Garden();
            Flower yellowFlower = new Flower();
            Flower blueFlower = new Flower();
            Tree purpleTree = new Tree();
            Tree orangeTree = new Tree();
            myLittleGarden.Plant.Add(yellowFlower);
            myLittleGarden.Plant.Add(blueFlower);
            myLittleGarden.Plant.Add(purpleTree);
            myLittleGarden.Plant.Add(orangeTree);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

using System;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car();
            Station firstStation = new Station();
            firstStation.Refill(audi);
            Console.WriteLine(audi.gasAmountOfCar);
            Console.ReadLine();
        }
    }
}

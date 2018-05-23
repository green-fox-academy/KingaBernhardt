using System;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car oneCar = new Car();
            Station firstStation = new Station();
            firstStation.Refill(oneCar);
            Console.WriteLine(oneCar.gasAmountOfCar);
            Console.ReadLine();
        }
    }
}

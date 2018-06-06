using System;

namespace AirCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            F16 f16 = new F16();
            Carrier plane = new Carrier(100, 100);
            f16.Refill(300000000);
            plane.Add(f16);
            plane.Add(f16);
            plane.Add(f16);
            plane.Add(f16);
            plane.Add(f16);
            Console.WriteLine(plane.GetStatus());
            Console.ReadLine();
        }
    }
}

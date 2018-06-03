using System;

namespace AirCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            AirCrafts britishAirways = new AirCrafts();
            F35 f35 = new F35();
            F16 f16 = new F16();

            Console.WriteLine(britishAirways.GetStatus());
            Console.ReadLine();

        }
    }
}

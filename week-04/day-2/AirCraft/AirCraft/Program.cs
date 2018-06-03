using System;

namespace AirCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            AirCrafts britishAirways = new AirCrafts();
            Carrier s56 = new Carrier(2500, 1450);
            Carrier e256 = new Carrier(6000, 320);

            s56.AddAirCraft(new F16());
            s56.AddAirCraft(new F16());
            s56.AddAirCraft(new F16());

            s56.AddAirCraft(new F35());
            s56.AddAirCraft(new F35());

            Console.WriteLine(s56.Fight(e256));
            Console.WriteLine(s56.GetStatus());
            Console.ReadLine();

        }
    }
}

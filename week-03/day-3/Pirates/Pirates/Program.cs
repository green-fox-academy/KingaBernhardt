using System;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate crewBob = new Pirate(5, true, false, "Bob");
            Pirate crewBerry = new Pirate(2, true, false, "Berry");
            Pirate captainRob = new Pirate(15, true, true, "Bob");

            Console.WriteLine(crewBob.DrinkSomeRum());
            Console.WriteLine(crewBerry.HowsItGoingMate());
            Console.WriteLine(captainRob.PrintOutPirates());

            Ship pirateShip = new Ship();
            Console.WriteLine(pirateShip.GetShipStatus());
            Console.WriteLine(pirateShip.MembersAlive());
            Console.WriteLine(pirateShip.MembersPassedOut());

            Console.ReadLine();
        }
    }
}

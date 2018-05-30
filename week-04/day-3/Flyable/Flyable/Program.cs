using System;

namespace Flyable
{
    class Program
    {
        static void Main(string[] args)
        {
            Helicopter AmbulanceHelicopter = new Helicopter(10, "white", 200);
            AmbulanceHelicopter.Fly();
            AmbulanceHelicopter.Land();
            AmbulanceHelicopter.TakeOff();
            Console.WriteLine();

            Bird blackBird = new Bird("Henry", 5);
            blackBird.Fly();
            blackBird.Land();
            blackBird.TakeOff();
            Console.WriteLine(blackBird.WantChild());
            Console.ReadLine();
        }
    }
}

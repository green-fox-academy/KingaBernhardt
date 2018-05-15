using System;
using System.Collections.Generic;

namespace SolarSystem_lists
{
    class Program
    {
        static void Main(string[] args)
        // Saturn is missing from the planetList
        // Insert it into the correct position
        // Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };

            foreach (var planet in PutSaturn(planetList))
            {
                Console.WriteLine(planet);
            }
            
            Console.ReadLine();
            
        }
        public static List<string> PutSaturn(List<string> planets)
        {
            planets.Insert(7, "Saturn");
            
            return planets;
        }
        
    }
}

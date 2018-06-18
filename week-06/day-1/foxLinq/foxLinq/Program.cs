using System;
using System.Collections.Generic;
using System.Linq;

namespace foxLinq
{
    class Program
    {
        //Create a Fox class with 3 properties(name, type, color)
        //Fill a list with at least 5 foxes, it's up to you how you name/create them!
        //Write a LINQ Expression to find the foxes with green color!
        //Write a LINQ Expression to find the foxes with green color and pallida type!

        static void Main(string[] args)
        {
            List<Fox> foxes = new List<Fox>()
            {
                new Fox() { Color = "red", Name = "Palinda", Type = "trigger" },
                new Fox() { Color = "yellow", Name = "Gando", Type = "fulvipes"},
                new Fox() { Color = "brown", Name = "Vuk", Type = "forest"},
                new Fox() { Color = "green", Name = "Dub", Type = "pallida"},
                new Fox() { Color = "green", Name = "Dub", Type = "minor"}
            };

            var findGreen = from g in foxes
                            where g.Color.Equals("green")
                            select g;

            foreach (var i in findGreen)
            {
                Console.WriteLine(i);
            }

            var findGreenPallida = from p in foxes
                                   where p.Color.Equals("green")
                                   where p.Type.Equals("pallida")
                                   select p;

            foreach (var item in findGreenPallida)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------");

            IEnumerable<Fox> findGreen2 = foxes.Where(p => p.Color.Equals("green"));

            findGreen2.ToList().ForEach(p => Console.WriteLine("This is green: " + p));

            IEnumerable<Fox> findGreenPallida2 = foxes.Where(p => p.Color.Equals("green") && p.Type.Equals("pallida"));

            findGreenPallida2.ToList().ForEach(p => Console.WriteLine("This is green and pallida type" + p));

            Console.ReadLine();
        }
    }
}

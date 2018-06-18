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
            };


        }
    }
}

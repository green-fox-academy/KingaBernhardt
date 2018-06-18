using System;
using System.Linq;
using System.Collections.Generic;

namespace FrequencyOfNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var freqNum = from num in n
                          group num by num into numGroup
                          select numGroup;
            foreach (var item in freqNum)
            {
                Console.WriteLine("Number " + item.Key + " appears " + item.Count() + " times.");
            }

            Console.WriteLine();

            var numFreq = n.GroupBy(x => x);
            foreach (var item in numFreq)
            {
                Console.WriteLine("Number " + item.Key + " appears " + item.Count() + " times.");
            }
            Console.ReadLine();
        }
    }
}

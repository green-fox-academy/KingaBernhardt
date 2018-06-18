using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageOfOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var averageOddNum = (from num in n
                                  where num % 2 != 0
                                  select num).Average();
            Console.WriteLine(averageOddNum);

            Console.WriteLine();

            var averageOddNum2 = n.Where(x => x % 2 != 0).Average();
            Console.WriteLine(averageOddNum2);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace GetEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            IEnumerable<int> evenNumbers = from num in n
                                           where num % 2 == 0
                                           orderby num ascending
                                           select num;
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            IEnumerable<int> evenNums = n.Where(x => x % 2 == 0).OrderBy(x => x);
            foreach (var i in evenNums)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

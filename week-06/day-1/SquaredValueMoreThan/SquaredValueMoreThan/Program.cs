using System;
using System.Collections.Generic;
using System.Linq;

namespace SquaredValueMoreThan
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var nums = from num in n
                       where num * num > 20
                       select num;
            foreach (var item in nums)
            {
                Console.Write("\nFind the number and its square of an array which is more than 20 : ");
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var nums2 = n.Where(x => x*x > 20);
            foreach (var item in nums2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

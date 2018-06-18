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
                       let squareNum = num * num
                       where squareNum > 20
                       select new { num, squareNum };
            foreach (var item in nums)
            {
                Console.Write("\nLINQ : Find the number and its square of an array which is more than 20 : ");
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

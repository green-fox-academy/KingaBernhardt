using System;
using System.Collections.Generic;
using System.Linq;

namespace SquaredValueOfPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> posNum = from num in n
                                      where num > 0
                                      let squareNum = num * num
                                      orderby squareNum ascending
                                      select squareNum;
            foreach (var item in posNum)
            {
                Console.WriteLine("The squared values of the positive numbers: {0}", item );
            }
            Console.ReadLine();
        }
    }
}

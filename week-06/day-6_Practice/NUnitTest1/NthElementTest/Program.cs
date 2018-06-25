using System;
using System.Collections.Generic;

namespace NthElementTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 4, 10, 34, 3, 16, 3, 21 };
            int n = 2;

            double result = GetAverageForNthElements(numbers, n);
            Console.WriteLine("The average for every {0} element is {1}", n, result);
            Console.ReadLine();
        }

        public static double GetAverageForNthElements(int[] numbers, int n)
        {
            List<int> nthNums = new List<int>() { };
            double sumNum = 0;
            for (int i = n-1; i < numbers.Length; i += n)
            {
                nthNums.Add(numbers[i]);
            }
            foreach (var item in nthNums)
            {
                sumNum += item;
            }

            double averageNum = sumNum / nthNums.Count;
            return averageNum;
        }
    }
}


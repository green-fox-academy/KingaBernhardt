using System;

namespace sumAllElements_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ai = new int[5] { 3, 4, 5, 6, 7 };
            Console.WriteLine(Sum(ai));
            Console.ReadLine();
        }
        public static int Sum (int[] summing)
        {
            int sum = 0;
            for (int i = 0; i < summing.Length; i++)
            {
                sum += summing[i];

            }
            return sum;
        }
    }
}

using System;

namespace SumDigit
{
    class Program
    // Given a non-negative int n, return the sum of its digits recursively (no loops). 
    // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
    // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a non-negative number less than 300");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(SumDigit(n));
            Console.ReadLine();
        }
        public static int SumDigit(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n % 10 + SumDigit(n / 10);
            }
        }
    }
}

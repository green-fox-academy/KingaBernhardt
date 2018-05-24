using System;

namespace NumberAdder
{
    class Program
    // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number less than 20.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberAdder(n));
            Console.ReadLine();
        }
        public static int NumberAdder(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + NumberAdder(n - 1);
            }
        }
    }
}

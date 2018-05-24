using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number less then 20.");
            int n = int.Parse(Console.ReadLine());
            CountBack(n);
            Console.ReadLine();
        }
        public static int CountBack(int n)
        {
            if (n == 0)
            {
               return 0;
            }
            else
            {
               Console.WriteLine(n);
               return CountBack(n - 1);
            }
        }
    }
}

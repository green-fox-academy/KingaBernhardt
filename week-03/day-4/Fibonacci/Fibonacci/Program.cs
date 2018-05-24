using System;

namespace Fibonacci
{
    class Program
        //The first two number addintion is the third number.
        //0, 1, 1, 2, 3, 5, 8, 13, 21
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFibonacci(8));
            Console.ReadLine();
        }
        public static int GetFibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return GetFibonacci(n - 1) + GetFibonacci(n - 2);
            }
        }
    }
}

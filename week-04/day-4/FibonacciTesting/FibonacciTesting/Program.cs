using System;

namespace FibonacciTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public int FibonacciForTesting(int numberOne)
        {
            if (numberOne == 0)
            {
                return 0;
            }
            else if (numberOne == 1)
            {
                return 1;
            }
            else
            {
                return FibonacciForTesting(numberOne - 1) + FibonacciForTesting(numberOne - 2);
            }
        }
    }
}

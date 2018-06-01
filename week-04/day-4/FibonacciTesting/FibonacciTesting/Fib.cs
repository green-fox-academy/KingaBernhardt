using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciTesting
{
    public class Fib
    {
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

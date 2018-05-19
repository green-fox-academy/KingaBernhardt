using System;

namespace fromOnToHundred_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i<100; i++)
            {
                switch (i % 3 == 0 && i % 5 == 0)
                {
                    case 1: Console.WriteLine("FizzBuzz");
                        break;
                    case 2: (i % 3 == 0);
                    Console.WriteLine("Fizz");
                        break;
                    case 3: (i % 5 == 0);
                    Console.WriteLine("Buzz");
                        break;
                    default:
                    Console.WriteLine(i);
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}

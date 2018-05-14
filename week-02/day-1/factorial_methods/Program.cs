using System;

namespace factorial_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(input));

            Console.ReadLine();
        }
        public static int Factorial (int input)
        {
            int factOfNumbers = 1;
            for (int i = 1 ; i <= input; i++)
            {
                factOfNumbers *= i;
            }
            return factOfNumbers;
        }
    }
}

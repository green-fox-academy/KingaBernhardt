using System;
using System.Linq;

namespace sumAndAverageOfIntegers
{
    class Program
    {
        private static object sumOfLength;

        static void Main(string[] args)
        {
            Console.Write("How many numbers would you like to enter? ");
            int numberOfIntegers = int.Parse(Console.ReadLine());
            double sumOfNumbers = 0;

            for (int i = 0; i < numberOfIntegers; i++)
            {
                Console.Write("Please enter a number: ");
                sumOfNumbers += double.Parse(Console.ReadLine());

            }

            double averageOfIntegers = sumOfNumbers / numberOfIntegers;
            Console.WriteLine("Sum: " + sumOfNumbers + ", Average: " + averageOfIntegers);

            Console.ReadLine();
        }
    }
}

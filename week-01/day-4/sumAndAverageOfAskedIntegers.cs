using System;
using System.Linq;

namespace sumAndAverageOfIntegers
{
    class Program
    {
        private static object sumOfLength;
        static void Main(string[] args)
        {
            Console.Write("How many numbers would you like to enter?");
            int numbersGivenbyUser = int.Parse(Console.ReadLine());
            double sumOfGivenNumbers = 0;

            for (int i = 0; i < numbersGivenbyUser; i++)
            {
                Console.Write("Please enter a number: ");
                sumOfGivenNumbers += double.Parse(Console.ReadLine());
            }
            double averageOfGivenNumbers = sumOfGivenNumbers / numbersGivenbyUser;
            Console.WriteLine("Sum: " + sumOfGivenNumbers + ", Average: " + averageOfGivenNumbers);
            Console.ReadLine();
        }
    }
}

using System;

namespace biggerOrNotCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number");
            int numberTwo = int.Parse(Console.ReadLine());

            if (numberOne < numberTwo)
            {
                for (int i = numberOne; i <=numberTwo; i++)
                {
                    Console.WriteLine(i);
                }
            } else if (numberOne>=numberTwo)
            {
                Console.WriteLine("The second number should be bigger");
            }
            Console.ReadLine();
        }
    }
}

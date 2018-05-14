using System;

namespace sum_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(input));
            
            Console.ReadLine();
        }
        public static int Sum (int input)
        {
            int sumOfInput = 0;
            for (int i = 0; i<= input; i++)
            {
                sumOfInput += i;

            }
            return sumOfInput;
        }
           
    }
}

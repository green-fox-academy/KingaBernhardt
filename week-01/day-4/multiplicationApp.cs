using System;

namespace multiplicationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1} = {2}" , number, i, number*i);
            }
            Console.ReadLine();
        }
    }
}

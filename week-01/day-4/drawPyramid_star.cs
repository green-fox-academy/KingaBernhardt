using System;

namespace drawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number: ");
            int numPyramid = int.Parse(Console.ReadLine());

            for (int i=1; i <= numPyramid; i++)
            {
                for (int j = 1; j <numPyramid-i+1 ; j++)
                {
                    Console.Write(" ");
                }
                for (int k= 1; k <=i; k++)
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

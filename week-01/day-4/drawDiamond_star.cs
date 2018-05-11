using System;

namespace drawDiamond_star
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDiamond = 0;

            do
            {
                Console.WriteLine("Enter an odd number:");
                numDiamond = Int32.Parse(Console.ReadLine());

            } while ((numDiamond < 3) || (numDiamond % 2 == 0));

            int firstPart = (numDiamond + 1) / 2;
            int secondPart = (numDiamond - 1) / 2;

            for (int i = 0; i < firstPart; i++)
            {
                for (int j = firstPart; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < i + i + 1; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            for (int i = 1; i < secondPart + 1; i++)
            {
                for (int x = 0; x < i + 1; x++)
                {
                    Console.Write(" ");
                }
                for (int j = numDiamond; j > i + i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine(numDiamond);
            Console.ReadLine();
        }
    }
}
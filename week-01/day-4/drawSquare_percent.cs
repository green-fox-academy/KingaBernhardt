using System;

namespace drawSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a pozitive number");
            int numSquare = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSquare; i++)
            {
                for (int j = 0; j < numSquare; j++)
                {
                    if (i == 0 || i == numSquare-1)
                    {
                        Console.Write("%");
                    }
                    else if (j == 0 || j == numSquare - 1)
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}

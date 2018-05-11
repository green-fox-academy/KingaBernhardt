using System;

namespace diagonalDraw_hastag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number");
            int numDiagonal = int.Parse(Console.ReadLine());
            
            for (int i=0; i <  numDiagonal; i++)
            {
                for (int j = 0; j < numDiagonal; j++)
                {
                    if (i == 0 || i == numDiagonal - 1)
                    {
                        Console.Write("%");
                    }
                    else if (j == numDiagonal-1 || j == 0)
                    {
                        Console.Write("%");
                    }
                    else if (i==j)
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

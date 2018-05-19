using System;

namespace drawChessTable_percent
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("% ");
                }
                Console.WriteLine();
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(" %");
                }
                Console.WriteLine()
            }
            Console.ReadLine();
        }
    }
}

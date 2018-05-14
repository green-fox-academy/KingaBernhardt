using System;

namespace matrix_twodimensional_arrays
{
    class Program
    // - Create (dynamically) a two dimensional array
    //   with the following matrix. Use a loop!
    //
    //   1 0 0 0
    //   0 1 0 0
    //   0 0 1 0
    //   0 0 0 1
    //
    // - Print this two dimensional array to the output

    {
        static void Main(string[] args)
        {
            int[,] twoDimensional = new int[4, 4]
            {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 }
            };
            for (int i = 0; i < twoDimensional.GetLength(0); i ++)
            {
                for (int j = 0; j < twoDimensional.GetLength(1); j++)

                {
                   Console.Write(" {0}", twoDimensional[i, j]);

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

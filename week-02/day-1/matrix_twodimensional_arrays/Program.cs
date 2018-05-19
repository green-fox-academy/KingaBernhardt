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
            for (int i = 0; i < 4; i ++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

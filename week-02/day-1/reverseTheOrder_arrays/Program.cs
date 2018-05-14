using System;

namespace reverseTheOrder_arrays
{
    class Program
    // - Create an array variable named `aj`
    //   with the following content: `[3, 4, 5, 6, 7]`
    // - Reverse the order of the elements in `aj`
    // - Print the elements of the reversed `aj`

    {
        static void Main(string[] args)
        {
            int[] aj = new int[] { 3, 4, 5, 6, 7 };
            int[] tempAj = new int[aj.Length];
            for (int i = 0; i < aj.Length; i++)
            {
                tempAj[i] = aj[i];
            }
            for (int i = 0; i < aj.Length; i++)
            {
                aj[i] = tempAj[aj.Length - i - 1];
                Console.WriteLine(aj[i]);
            }
            Console.ReadLine();

        }
    }
}

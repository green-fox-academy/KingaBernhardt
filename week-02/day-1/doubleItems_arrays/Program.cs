using System;

namespace doubleItems_arrays
{
    class Program
    {
        static void Main(string[] args)
        // - Create an array variable named `numList`
        //   with the following content: `[3, 4, 5, 6, 7]`
        // - Double all the values in the array

        {
            int[] numbersOfArray= new int[] { 3, 4, 5, 6, 7 };
            int[] doubleNumber = new int[numbersOfArray.Length];
            for (int i = 0; i < numbersOfArray.Length; i++)
            {
                doubleNumber[i] = numbersOfArray[i] * 2;
                Console.WriteLine(doubleNumber[i]);
            }
            Console.ReadLine();
        }
    }
}

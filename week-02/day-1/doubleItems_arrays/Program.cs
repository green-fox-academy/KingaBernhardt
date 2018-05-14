using System;

namespace doubleItems_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numList= new int[] { 3, 4, 5, 6, 7 };
            for (int i = 0; i < numList.Length; i++)
            {
                int[] doubledNumList = new int[5];
                doubledNumList[i] = numList[i] * 2;
                Console.WriteLine(doubledNumList[i]);

            }
            Console.ReadLine();
        }
    }
}

using System;

namespace printElements_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 4, 5, 6, 7 };
            for (int i=0; i< numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace incrementElements_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[] { 1, 2, 3, 4, 5 };
            t[3] += 6;
            Console.WriteLine(t[3]);
            Console.ReadLine();
        }
    }
}

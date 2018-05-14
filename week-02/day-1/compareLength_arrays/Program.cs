using System;

namespace compareLength_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = new int[] { 1, 2, 3 };
            int[] p2 = new int[] { 4, 5 };
            if (p2.Length>p1.Length)
            {
                Console.WriteLine("P2 has more elements: " + p2);
            } else
            {
                Console.WriteLine("P1 has more elements than P2");
            }
            Console.ReadLine();
        }
    }
}

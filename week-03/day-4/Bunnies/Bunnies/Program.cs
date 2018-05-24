using System;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        // We have a number of bunnies and each bunny has two big floppy ears.
        // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).
        {
            Console.WriteLine("Give me how many bunny do you want");
            int bunniesNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Bunnies(bunniesNumber));
            Console.ReadLine();
        }
        public static int Bunnies(int bunniesNumber)
        {
            if (bunniesNumber == 0)
            {
                return 0;
            }
            else
            {
                return 2 + (Bunnies(bunniesNumber-1));
            }
        }
    }
}

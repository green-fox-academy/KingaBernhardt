using System;

namespace Bunnies2
{
    class Program
    // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
    // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
    // have 3 ears, because they each have a raised foot. Recursively return the
    // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many bunny you want");
            int bunnyNums = int.Parse(Console.ReadLine());
            Console.WriteLine(BunniesTwo(bunnyNums));
            Console.ReadLine();
        }
        public static int BunniesTwo(int bunnyNums)
        {
            if (bunnyNums == 0)
            {
                return 0;
            }
            else if (bunnyNums % 2 == 0)
            {
                return 3 + (BunniesTwo(bunnyNums - 1));
            }
            else
            {
                return 2 + (BunniesTwo(bunnyNums - 1));
            }
        }
    }
}

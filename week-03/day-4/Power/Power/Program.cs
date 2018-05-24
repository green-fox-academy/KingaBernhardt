using System;

namespace Power
{
    class Program
    // Given base and n that are both 1 or more, compute recursively (no loops)
    // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
    {
        static void Main(string[] args)
        {
            int baseNumber = 0;
            int powerNumGivenByUser = 0;
            Console.WriteLine("Please enter a base number less than 20");
            baseNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a power less than 10");
            powerNumGivenByUser = int.Parse(Console.ReadLine());

            Console.WriteLine("The result is: " + Power(baseNumber, powerNumGivenByUser));
            Console.ReadLine();
        }
        public static int Power(int baseNumber, int PowerNum)
        {
            if (PowerNum == 0)
            {
                return 1;
            }
            else
            {
                return baseNumber * Power(baseNumber, PowerNum - 1);
            }
        }
    }
}

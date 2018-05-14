using System;

namespace doubling_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum = 123;
            Console.WriteLine(Doubling(baseNum));
            Console.ReadLine();
        }
        public static double Doubling ( double baseNum)
        {
            return baseNum + baseNum;
        }
    }
}

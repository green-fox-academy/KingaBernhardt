using System;

namespace doubling_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNumber = 123;
            Console.WriteLine(Doubling(givenNumber));
            Console.ReadLine();
        }
        public static double Doubling ( double givenNumber)
        {
            return givenNumber *4;
        }
    }
}

using System;

namespace Reverse_strings
{
    class Program
    {
        static void Main(string[] args)
        // Create a method that can reverse a String, which is passed as the parameter
        // Use it on this reversed string to check it!
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

           

            Console.WriteLine(Reverse(reversed));
            Console.ReadLine();
        }
        public static string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

using System;
using System.Collections.Generic;

namespace QuoteSwap_lists
{
    class Program
    {
        static void Main(string[] args)
        // Accidentally I messed up this quote from Richard Feynman.
        // Two words are out of place
        // Your task is to fix it by swapping the right words with code
        // Create a method called QuoteSwap().

        // Also, print the sentence to the output with spaces in between.
        // Expected output: "What I cannot create I do not understand." 
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            Console.WriteLine(QuoteSwap(list));
           
            Console.ReadLine();
        }
        public static string QuoteSwap(List<string> sentence)
        {
            int index = sentence.IndexOf("cannot");
            int index2 = sentence.IndexOf("do");
            string tempElement = sentence[index];
            sentence[index] = sentence[index2];
            sentence[index2] = tempElement;

            return string.Join(" ", sentence);

        }
    }
}

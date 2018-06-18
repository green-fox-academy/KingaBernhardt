using System;
using System.Linq;
using System.Collections.Generic;

namespace FrequencyOfCharacters
{
    class Program
    {
        //Write a LINQ Expression to find the frequency of characters in a given string!
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a word");
            string givenWord = Console.ReadLine();

            var freq = from n in givenWord
                       where n = n
        }
    }
}

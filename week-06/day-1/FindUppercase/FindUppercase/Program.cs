using System;
using System.Collections.Generic;
using System.Linq;

namespace FindUppercase
{
    class Program
    {
        //Write a LINQ Expression to find the uppercase characters in a string!
        static void Main(string[] args)
        {
            string word = "haLE";
            IEnumerable<char> letter = from n in word
                                       where char.IsUpper(n)
                                       select n;

            foreach (var item in letter)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            IEnumerable<char> upLetter2 = word.Where(u => char.IsUpper(u));
            foreach (var item in upLetter2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

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

            Dictionary<char, int> charFreq = (from character in givenWord
                                             group character by character into charCounter
                                             select charCounter).ToDictionary(g => g.Key, g => g.ToList().Count);

            charFreq.ToList().ForEach(p => Console.WriteLine($"key {p.Key}, value {p.Value}"));

            Console.WriteLine();

            Dictionary<char, int> lambdaDic = givenWord.Where(x => x != ' ')
                                                      .GroupBy(x => x)
                                                      .ToDictionary(x => x.Key, x => x.ToList().Count);

            foreach (KeyValuePair<char, int> item in lambdaDic)
            {
                Console.Write($"{item.Key}: {item.Value} , ");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace CountLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
        public Dictionary<char, int> CountLetters(string givenWord)
        {
            Dictionary<char, int> setWords = new Dictionary<char, int>();
            for (int i = 0; i < givenWord.Length; i++)
            {
                if (setWords.ContainsKey(givenWord[i]))
                {
                    setWords[givenWord[i]]++;
                }
                else
                {
                    setWords.Add(givenWord[i], 1);
                }
            }
            return setWords;
        }
    }
}

using System;

namespace Anagram_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter one word!");
            string firstGivenWord = Console.ReadLine();
            Console.WriteLine("Please enter a second word!");
            string secondGivenWord = Console.ReadLine();
            bool isAnagramOrNot = AnagramFirstSolution(firstGivenWord, secondGivenWord);
            Console.WriteLine(isAnagramOrNot);

            Console.WriteLine("Please enter one word!");
            string wordOne = Console.ReadLine();
            Console.WriteLine("Please enter a second word!");
            string wordTwo = Console.ReadLine();
            bool stillAnagramOrNot = AnagramSecondSolution(wordOne, wordTwo);

            Console.ReadLine();
        }

        public static bool AnagramFirstSolution(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }
            else if (word1 == word2)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    for (int j = 0; j < word2.Length; j++)
                    {
                        if (word1[i] == word2[j])
                        {
                            word2 = " " + word2.Remove(j, 1);
                        }
                        else if (j == word1.Length - 1)
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                return true;
            }
            return true;
        }

        public static bool AnagramSecondSolution(string wordOne, string wordTwo)
        {
            char[] WordOneArray = wordOne.ToCharArray();
            char[] WordTwoArray = wordTwo.ToCharArray();
            if (WordOneArray.Length != WordTwoArray.Length)
            {
                return false;
            }
            else
            {
                Array.Sort(WordOneArray);
                Array.Sort(WordTwoArray);
                return WordOneArray.ToString().Equals(WordTwoArray.ToString());
            }
        }
    }
}

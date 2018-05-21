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
            bool isAnagramOrNot = Anagram(firstGivenWord, secondGivenWord);
            Console.WriteLine(isAnagramOrNot);
            Console.ReadLine();
        }
        public static bool Anagram(string word1, string word2)
        {
            string createdWord = "";
            int sameLetter = 0;
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
                            break;
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
    }
}

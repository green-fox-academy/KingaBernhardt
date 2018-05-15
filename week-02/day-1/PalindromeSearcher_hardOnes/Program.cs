using System;

namespace PalindromeSearcher_hardOnes
{
    class Program
    //Create a function named search palindrome
    //following your current language's style guide.
    //It should take a string, search for palindromes that at least 3 characters long
    //and return a list with the found palindromes.
    {
        static void Main(string[] args)
        {
            string palNames = "civic, repaper, redder, level, monkey, goat, duck";

            Console.Write(SearchPalindrome(palNames));
            Console.ReadLine();
        }
        public static string ReverseString (string vs)
        {
            string reverseString = "";
            for (int i = vs.Length - 1; i >= 0; i--)
            {
                reverseString += vs[i];
            }
            return reverseString;
        }
        public static string SearchPalindrome(string palNames)
        {
            string solution = "" ;
            for (int j = 0; j < palNames.Length; j++)
            {
                for (int k = 3; k + j <= palNames.Length; k++)
                {
                    string partOfPalNames = palNames.Substring(j, k);
                    if (partOfPalNames == ReverseString(partOfPalNames))
                    {
                        solution += partOfPalNames + ", ";
                    }

                }
            }
            return solution;
        }
    }
}

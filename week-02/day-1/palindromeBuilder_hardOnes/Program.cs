using System;

namespace palindromeBuilder_hardOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = "giraffe";
            Console.WriteLine(CreatePalindrome(animal));
            Console.ReadLine();
        }
        public static string CreatePalindrome (string potentialPalindrome)
        {
            string palindrome = potentialPalindrome;

            for (int i = palindrome.Length - 1; i >= 0 ; i--)
            {
                palindrome += potentialPalindrome[i];
            }
            return palindrome;
        }
    }
}

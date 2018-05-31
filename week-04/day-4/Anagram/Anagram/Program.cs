using System;

namespace Anagram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }

        public bool GetAnagram(string givenWordOne, string givenWordTwo)
        {
            char[] givenWordOneArray = givenWordOne.ToCharArray();
            char[] givenWordTwoArray = givenWordTwo.ToCharArray();
            if (givenWordOneArray.Length != givenWordTwoArray.Length)
            {
                return false;
            }
            else
            {
                Array.Sort(givenWordOneArray);
                Array.Sort(givenWordTwoArray);
                return givenWordOneArray.ToString().Equals(givenWordTwoArray.ToString());
            }
        }
    }
}

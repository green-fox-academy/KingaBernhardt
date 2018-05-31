using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
        }

        public bool GetAnagram(string givenWordOne, string givenWordTwo)
        {
            if (givenWordOne.Length != givenWordTwo.Length)
            {
                return false;
            }
            else if (givenWordOne == givenWordTwo)
            {
                for (int i = 0; i < givenWordOne.Length; i++)
                {
                    for (int j = 0; j < givenWordTwo.Length; j++)
                    {
                        if (givenWordOne[i] == givenWordTwo[j])
                        {
                            givenWordTwo = " " + givenWordTwo.Remove(j, 1);
                        }
                        else if (j == givenWordOne.Length - 1)
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
    }
}

using System;

namespace String2
{
    class Program
    // Given a string, compute recursively a new string where all the 'x' chars have been removed.
    {
        static void Main(string[] args)
        {
            string givenString = "xaxo";
            Console.WriteLine(StringTwo(givenString));
            Console.ReadLine();
        }
        public static string StringTwo(string givenString)
        {
            string tempWord = givenString;
            if (tempWord.Contains("x"))
            {
                return StringTwo(tempWord.Remove('x'));
            }
            else
            {
                return tempWord;
            }
        }
    }
}

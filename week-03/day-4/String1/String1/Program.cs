using System;

namespace String1
{
    class Program
    // Given a string, compute recursively (no loops) a new string where all the
    // lowercase 'x' chars have been changed to 'y' chars.
    {
        static void Main(string[] args)
        {
            string givenWord = "yyyyyyxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxylophone";
            Console.WriteLine(StringOne(givenWord));
            Console.ReadLine();
        }
        public static string StringOne(string givenWord)
        {
            string permWord = givenWord;
            if (permWord.Contains("x"))
            {
                return StringOne(permWord.Replace("x","y"));
            }
            else
            {
                return permWord;
            }
        }
    }
}

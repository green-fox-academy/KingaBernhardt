using System;

namespace String1
{
    class Program
    // Given a string, compute recursively (no loops) a new string where all the
    // lowercase 'x' chars have been changed to 'y' chars.
    {
        static void Main(string[] args)
        {
            string givenWord = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxylophone";
            Console.WriteLine(StringOne(givenWord));
            Console.ReadLine();
        }
        public static string StringOne(string givenWord)
        {
            char temp;
            if (givenWord == "")
            {
                return null;
            }
            if (givenWord[0] == 'x')
            {
                temp = 'y';
            }
            else
            {
                temp = givenWord[0];
            }
            return temp + StringOne(givenWord.Remove(0,1));
        }
    }
}

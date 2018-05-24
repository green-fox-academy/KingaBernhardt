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
            if (givenString == "")
            {
                return null;
            }
            if (givenString[0] == 'x')
            {
                return StringTwo(givenString.Remove(0, 1));
            }
            else
            {
                return givenString[0] + StringTwo(givenString.Remove(0, 1));
            }
        }
    }
}

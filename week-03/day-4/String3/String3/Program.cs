using System;

namespace String3
{
    class Program
    // Given a string, compute recursively a new string where all the
    // adjacent chars are now separated by a "*".
    {
        static void Main(string[] args)
        {
            string givenInput = "cool";
            Console.WriteLine(StringThree(givenInput));
            Console.ReadLine();
        }
        public static string StringThree(string givenInput)
        {
            if (givenInput.Length - 1 <= 0 )
            {
                return givenInput[0].ToString();
            }
            else
            {
                return givenInput[0] + "*" + StringThree(givenInput.Remove(0, 1));
            }
        }
    }
}

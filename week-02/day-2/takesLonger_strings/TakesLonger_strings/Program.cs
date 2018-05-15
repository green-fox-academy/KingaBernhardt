using System;

namespace TakesLonger_strings
{
    class Program
    {
        static void Main(string[] args)
        // When saving this quote a disk error has occured. Please fix it.
        // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
        // Using pieces of the quote variable (instead of just redefining the string)

        {
            string quote = "\"Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.\"";
            quote = string.Format("\"Hofstadter's Law: It {0} you expect, even when you take into account Hofstadter's Law.\"", "always takes longer than");


            Console.WriteLine(quote);
            Console.ReadLine();
        }
    }
}

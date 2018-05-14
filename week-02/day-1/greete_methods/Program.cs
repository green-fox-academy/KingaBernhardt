using System;

namespace greete_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";

            Console.WriteLine(Greet(al));
            Console.ReadLine();
        }
        public static string Greet(string al)
        {
            return "Greeting dear, " + al;
        }
    }
}

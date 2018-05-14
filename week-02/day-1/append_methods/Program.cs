using System;

namespace append_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";

            Console.WriteLine(AppendA(am));
            Console.ReadLine();
        }
        public static string AppendA (string am)
        {
            return am + "a";
        }
    }
}

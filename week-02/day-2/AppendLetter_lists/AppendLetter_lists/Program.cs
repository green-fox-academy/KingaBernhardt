using System;
using System.Text;
using System.Collections.Generic;

namespace AppendLetter_lists
{
    class Program
    {
        static void Main(string[] args)
        // Create a method called AppendA() that adds "a" to every string in the far list.
        // The parameter should be a list.
        // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"

        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            foreach (var item in AppendA(far))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public static List<string> AppendA(List<string> far)
        {
            for (int i = 0; i < far.Count; i++)
            {
                far[i] += "a";
            }
            return far;
        }
    }
}

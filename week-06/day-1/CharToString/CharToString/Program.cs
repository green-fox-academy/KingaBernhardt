using System;
using System.Collections.Generic;
using System.Linq;

namespace CharToString
{
    class Program
    {
        //Write a LINQ Expression to convert a char array to a string!
        static void Main(string[] args)
        {
            char[] myArray = { 'a', 'g', 'y' };

            /*IEnumerable<string> makeString = from m in myArray
                                             where char.*/

            var makeString2 = string.Join("", myArray.Select(a => a));
            Console.WriteLine(makeString2);
            Console.ReadLine();
        }
    }
}

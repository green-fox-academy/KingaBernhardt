using System;

namespace SimpleReplace_strings
{
    class Program
    {
        static void Main(string[] args)
        // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
        // Please fix it for me!
        // Expected ouput: In a galaxy far far away

        {
            string example = "In a dishwaser far far away.";
            example = example.Replace("dishwaser", "galaxy");

            Console.WriteLine(example);
            Console.ReadLine();
        }
    }
}

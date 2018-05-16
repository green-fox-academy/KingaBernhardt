using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(File.ReadAllText("my-list.txt"));
            string attachedFile = "my-list.txt";

            try
            {
                Console.WriteLine(File.ReadAllText("my-list.txt"));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Unable to read file: " + attachedFile);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

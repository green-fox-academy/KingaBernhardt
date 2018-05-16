using System;
using System.IO;
using System.Text;
using System.Collections.Generic;


namespace WriteSingleLine
{
    class Program
    // Open a file called "my-file.txt"
    // Write your name in it as a single line
    // If the program is unable to write the file,
    // then it should print an error message like: "Unable to write file: my-file.txt"

    {
        static void Main(string[] args)
        {
            try
            {
                File.WriteAllText(@"C:\Users\kinga\OneDrive\Desktop\Green Fox Academy\greenfox\KingaBernhardt\week-02\day-3\Practice\WriteSingleLine\WriteSingleLine\my-file.txt", "Kinga Bernhardt");

            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my - file.txt");
            }
        }
    }
}

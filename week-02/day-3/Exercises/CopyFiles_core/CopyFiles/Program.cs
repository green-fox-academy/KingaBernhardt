using System;
using System.Collections.Generic;
using System.IO;


namespace CopyFiles
{
    class Program
    {
        static void Main(string[] args)
        // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
        // It should take the filenames as parameters
        // It should return a boolean that shows if the copy was successful

        {
            string oldFile = "copy-file.txt";
            Console.WriteLine(Copy(oldFile));
            Console.ReadLine();
        }
        public static bool Copy(string fileNames)
        {
            try
            {
                string[] savedFile = File.ReadAllLines(fileNames);
                File.WriteAllLines(@"C:\Users\kinga\OneDrive\Desktop\Green Fox Academy\greenfox\KingaBernhardt\week-02\day-3\Exercises\CopyFiles_core\CopyFiles\new-fileCopy.txt", savedFile);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesOfFile = File.ReadLines("new-file.txt").Count();

            try
            {
                Console.WriteLine(linesOfFile);
            }

            catch (Exception)
            {
                Console.WriteLine("0");
            }


            string[] fileOfMine = File.ReadAllLines("new-file.txt");
            Console.WriteLine(OtherWayWithoutUsingLinq(fileOfMine));
            Console.ReadLine();
        }
        public static int OtherWayWithoutUsingLinq(string[] number)
        {
            int counter = 0;
            try
            {
                for (int i = 0; i < number.Length; i++)
                {
                    counter++;
                }
                return counter;
            }
            catch (Exception)
            {
               return "0";
            }
        }
    }
}

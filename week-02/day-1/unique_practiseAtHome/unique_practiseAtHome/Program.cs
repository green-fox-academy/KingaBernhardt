using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace unique_practiseAtHome
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> () { 1, 11, 34, 11, 52, 61, 1, 34 };
            
            foreach (var item in Unique(numbers))
            {
                Console.Write(item + " , ");
            }
            Console.ReadLine();
        }

        public static List<int> Unique(List<int> numbers)
        {
            List<int> tempNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (tempNumbers.Contains(numbers[i]) == false)
                {
                    tempNumbers.Add(numbers[i]);
                }
            }
            return tempNumbers;
        }
    }
}

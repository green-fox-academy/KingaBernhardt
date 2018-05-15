using System;
using System.Collections.Generic;

namespace ElementFinder_lists
{
    class Program
    {
        static void Main(string[] args)
            // Write a method that checks if the arrayList contains "7" if it contains return "Hoorray" otherwise return "Noooooo"
            // The output should be: "Noooooo"
            // Do this again with a different solution using different list methods!
           
        {
            var List = new List<int> { 1, 2, 3, 4, 5 , 7};
            Console.WriteLine(ContainsSeven(List));
            Console.ReadLine();


        }
        public static string ContainsSeven(List<int> numbersList)
        {
            string input = "7";
            int number = Int32.Parse(input);
            string output = "Noo";
            
            for (int i = 0; i < numbersList.Count; i++)
            {
                    if (i == number) 
                    {
                        return "Hurray";
                    }
            }
            return output;
        }
        public static string OtherSolution (List<int> numberList)
        {
            if (numberList.Contains(7))
            {
                return "Hurray";
            }
            else
            {
                return "Nooo";
            }
        }
    }
}

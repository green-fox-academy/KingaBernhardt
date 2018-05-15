using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IsInList_lists
{
    class Program
    {
        static void Main(string[] args)
        // Check if list contains all of the following elements: 4,8,12,16
        // Create a method that accepts list as an input
        // it should return "true" if it contains all, otherwise "false"

        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 8, 16 };
            var inputList = new List<int> { 4, 8, 12, 16, 5 };
           
            Console.WriteLine(CheckNums(list));
            Console.WriteLine(CheckNums2(list,inputList));
            Console.ReadLine();


        }
        public static bool CheckNums(List<int> checkList)
        {

            if (checkList.Contains(4) && checkList.Contains(8) && checkList.Contains(16) && checkList.Contains(16))
            {
                return true;
            }
            return false;
        }
        public static bool CheckNums2(List<int> list, List<int> inputList)
        {
            int output = 0;
            for (int i = 0; i < inputList.Count; i++)
            {
                if (list.Contains(inputList[i]))
                {
                    output++;
                }
            }
            if (output == inputList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}

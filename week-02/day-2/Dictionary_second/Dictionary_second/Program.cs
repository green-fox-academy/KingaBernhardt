﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Dictionary_second
{
    class Program
    {
        static void Main(string[] args)
        // Display the following things:
        //  - Who has got more candies than 4 candies
        //  - Sum the age of people who have lass than 5 candies
        
        {

            var map = new List<Dictionary<string, object>>();

            var row0 = new Dictionary<string, object>();
            row0.Add("name", "Rezso");
            row0.Add("age", 9.5);
            row0.Add("candies", 2);
            map.Add(row0);

            var row1 = new Dictionary<string, object>();
            row1.Add("name", "Gerzson");
            row1.Add("age", 10);
            row1.Add("candies", 1);
            map.Add(row1);

            var row2 = new Dictionary<string, object>();
            row2.Add("name", "Aurel");
            row2.Add("age", 7);
            row2.Add("candies", 3);
            map.Add(row2);

            var row3 = new Dictionary<string, object>();
            row3.Add("name", "Zsombor");
            row3.Add("age", 12);
            row3.Add("candies", 5);
            map.Add(row3);

            var row4 = new Dictionary<string, object>();
            row4.Add("name", "Olaf");
            row4.Add("age", 12);
            row4.Add("candies", 7);
            map.Add(row4);

            var row5 = new Dictionary<string, object>();
            row5.Add("name", "Teodor");
            row5.Add("age", 3);
            row5.Add("candies", 2);
            map.Add(row5);

            int totalAge = 0;

            foreach (Dictionary<string,object> item in map)
            {
                if (Convert.ToInt32(item["candies"]) > 4)
                {
                    Console.WriteLine(item["name"]);
                }
                if (Convert.ToInt32(item["candies"]) < 5)
                {
                    totalAge = totalAge + Convert.ToInt32(item["age"]);
                }
            }
            Console.WriteLine("Total age who get less then five candies: " + totalAge);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace StartEndString
{
    class Program
    {
        //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            IEnumerable<string> city = from c in cities
                                       where c.StartsWith('A')
                                       where c.EndsWith('I')
                                       select c;
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            IEnumerable<string> city2 = cities.Where(c => c.StartsWith('A')).Where(d => d.EndsWith('I'));
            foreach (var item in city2)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}

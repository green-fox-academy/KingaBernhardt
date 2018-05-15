using System;
using System.Collections.Generic;

namespace MatchMaking_lists
{
    class Program
    {
        static void Main(string[] args)
        // Write a method that joins the two lists by matching one girl with one boy into a new list
        // Exepected output: "Eve", "Joe", "Ashley", "Fred"...
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };


            Console.Write(MakingMatches(girls, boys));
            Console.ReadLine();
        }
        public static string MakingMatches(List<string> girls, List<string> boys)
        {
            string joinedString = "";

            for (int i = 0; i < girls.Count; i++)
            {
                for (int j = 0; j < boys.Count; j++)
                {
                    if (i == j)
                    {
                        joinedString += ("\"" + girls[i] + "\"", "\""+ boys[j] + "\"");
                    }
                }
            }
            return joinedString;
        }

    }
}

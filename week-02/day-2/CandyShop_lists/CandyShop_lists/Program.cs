using System;
using System.Collections.Generic;
using System.Text;

namespace CandyShop_lists
{
    class Program
    {
        static void Main(string[] args)
        // Accidentally we added "2" and "false" to the list.
        // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
        // No, don't just remove the lines
        // Create a method called Sweets() which takes the list as a parameter.
        // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"

        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            Console.WriteLine(Sweets(list));
            Console.ReadLine();
            
        }
        public static StringBuilder Sweets(List<object> candy)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < candy.Count; i++)
            {
                if (candy[i].GetType() == typeof(int))
                {
                    output.Append("\"Croissant\", ");
                }
                else if (candy[i].GetType() == typeof(bool))
                {
                    output.Append("\"Ice Cream\"");
                }
                else
                {
                    output.Append($"\"{candy[i]}\", ");
                }
            }
            return output;
        }
    }
}

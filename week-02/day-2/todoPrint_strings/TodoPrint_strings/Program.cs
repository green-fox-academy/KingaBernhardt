using System;
using System.Collections.Generic;

namespace TodoPrint_strings
{
    class Program
    {
        static void Main(string[] args)

        // Add "My todo:" to the beginning of the todoText
        // Add " - Download games" to the end of the todoText
        // Add " - Diablo" to the end of the todoText but with indentation

        // Expected output:

        // My todo:
        //  - Buy milk
        //  - Download games
        //      - Diablo
        { 

        List<string> todoText = new List<string>();

        todoText.Add( " - Buy milk");
        
            todoText.Insert(0, "My todo:");
            todoText.Insert(2, " - Download games");
            todoText.Insert(3, " - Diablo");

            foreach (string todos in todoText)
            {
                Console.WriteLine(todos);
            }
            Console.ReadLine();
        }
    }
}

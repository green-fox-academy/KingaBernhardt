using System;
using System.Collections.Generic;

namespace IPrintable
{
    class Program
    {
        static void Main(string[] args)
        {
            Todo t = new Todo();
            List<Todo> todos = new List<Todo>();
            
            t.PrintAllFields();
            Console.WriteLine();
            Domino d = new Domino(3, 5);
            d.PrintAllFields();
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}

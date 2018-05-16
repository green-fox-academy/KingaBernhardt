using System;
using System.IO;
using System.Text;


namespace DividebyZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double userInput = Int32.Parse(Console.ReadLine());
            double myInput = 10;
            double result = userInput / myInput;
            if (result > 0)
            {
                Console.WriteLine(result);
            }
            else if (userInput == 0)
            {
                Console.WriteLine("Fail");
            }
            Console.ReadLine();
        }
    }
}

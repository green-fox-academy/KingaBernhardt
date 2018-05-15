using System;
using System.Collections.Generic;

namespace Calculator_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in the operator");
            string yourInput = Console.ReadLine();
            Console.WriteLine(Calculate(yourInput));
            Console.ReadLine();
        }
        public static string Calculate(string yourInput)
        {
            string[] splitInput = yourInput.Split(' ');
            string myOrerator = splitInput[0];
            double firstNumber = Convert.ToDouble(splitInput[1]);
            double secondNumber = Convert.ToDouble(splitInput[2]);

            if (myOrerator == "+")
            {
                double mySolution = firstNumber + secondNumber;
                return "Your solution is " + mySolution;
            }
            else if (myOrerator == "-")
            {
                double mySolution = firstNumber - secondNumber;
                return "Your solution is " + mySolution;
            }
            else if (myOrerator == "*")
            {
                double mySolution = firstNumber * secondNumber;
                return "Your solution is " + mySolution;
            }
            else if (myOrerator == "/")
            {
                double mySolution = firstNumber / secondNumber;
                return "Your solution is " + mySolution;
            }
            else if (myOrerator == "%" )
            {
                double mySolution = firstNumber % secondNumber;
                return "Your solution is " + mySolution;
            }
            else
            {
                return "Please specify your input";
            }
        }
    }
}

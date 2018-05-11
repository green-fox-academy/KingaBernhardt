using System;

namespace starTriangel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number");
            int numTriangel = int.Parse(Console.ReadLine());
            string starNum = "*";
            
            for (int i = 0; i<=numTriangel; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(starNum);
                }
                Console.Write('\n');
            }
            Console.ReadLine();
        }
    }
}

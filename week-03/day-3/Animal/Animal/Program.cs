using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal camel = new Animal();
            Console.WriteLine(camel.Drink());
            Console.WriteLine(camel.Eat());
            foreach (var item in camel.Play())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

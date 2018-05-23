using System;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie Matey = new Sharpie("white", 0.5f);
            Sharpie Lola = new Sharpie(100);
            Matey.Use(11);
            Lola.Use(21);
            Console.WriteLine("Lola is " + Lola.color + " it is " + Lola.width + " big, and the ink amount is " + Lola.inkAmount);
            Console.WriteLine("Matey is " + Matey.color + " it is " + Matey.width + "big and it's ink amount is " + Matey.inkAmount);
            Console.ReadLine();
        }
    }
}

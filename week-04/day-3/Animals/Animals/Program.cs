using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var reptile = new Reptile("Crocodile", 34);
            var mammal = new Mammal("Koala", 43);
            var bird = new Bird("Parrot", 21);

            Console.WriteLine("Who want a baby?");
            Console.WriteLine(reptile.GetName() + ", who is "+ reptile.Age + " month old and " + reptile.WantChild());
            Console.WriteLine(mammal.GetName() + ", who is " + mammal.Age + " month old and " + mammal.WantChild());
            Console.WriteLine(bird.GetName() + ", who is " + bird.Age + " month old and " + bird.WantChild());
            Console.ReadLine();
        }
    }
}

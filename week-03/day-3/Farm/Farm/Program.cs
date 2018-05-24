using System;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm dog = new Farm(30);
            Farm cat = new Farm(10);
            Animal giraffe = new Animal();
            Animal elephant = new Animal();
            dog.Breed();
            Console.WriteLine(dog.GetAnimalIndexHunger());
            Console.ReadLine();
        }
    }
}

using System;


namespace SharpieSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SharpieSet dogsOfSharpieSet = new SharpieSet();
            dogsOfSharpieSet.sharpies.Add(new Sharpie(2.4f));
            dogsOfSharpieSet.sharpies.Add(new Sharpie("yellow", 1.2f));
            dogsOfSharpieSet.sharpies.Add(new Sharpie("black"));
            Console.WriteLine(dogsOfSharpieSet.sharpies.Count);

            Console.WriteLine(dogsOfSharpieSet.CountUsable());
            Console.WriteLine(dogsOfSharpieSet.RemoveTrash());
            Console.ReadLine();

        }
    }
}

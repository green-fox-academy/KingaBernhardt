using System;

namespace guessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A random number is generated between 1-50. Guess pls:");
            string quessQuestion = Console.ReadLine();
            int numberOfGuesser;
            int.TryParse(quessQuestion, out numberOfGuesser);
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 50);

            while (numberOfGuesser != randomNumber)
            {
                if (numberOfGuesser > randomNumber)
                {
                    Console.WriteLine("The stored number is lower");

                }
                else if (numberOfGuesser < randomNumber)
                {
                    Console.WriteLine("The stored number is higher");

                }
                Console.WriteLine("Give me another number:");
                string guessQuestion = Console.ReadLine();
                int.TryParse(guessQuestion, out numberOfGuesser);

            }
            if (numberOfGuesser == randomNumber)
            {
                Console.WriteLine("Congratulations!  The generated number was:" + randomNumber);
            }
            Console.ReadLine();


        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess;

        do
        {
            Console.Write("What is your guess? ");
            string userInput2 = Console.ReadLine();
            guess = int.Parse(userInput2);

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (magicNumber != guess);
    }
}
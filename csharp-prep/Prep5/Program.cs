using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            return number;
        }

        static int SquareNumber(int number)
        {
            int squareNumber = number*number;

            return squareNumber;
        }

        static void DisplayResult(int squareNumber, string name)
        {
            Console.WriteLine($"{name}, the square of your number is {squareNumber}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(squareNumber, name);

    }
}
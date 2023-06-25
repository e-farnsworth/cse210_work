using System;

class Program
{
    static void Main(string[] args)
    {

        // do {...} (while input != quit or all words are not hidden)
        string userInput = "";
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.", reference);

        while (userInput != "quit")
        {
            Console.WriteLine(scripture.Display());

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();

            if (scripture.CompletelyHidden() == true)
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }
        
    }
}
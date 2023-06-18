using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");
        
        string choice ;

        do
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal1.AddEntry();
            }
            else if (choice == "2")
            {
                journal1.Display();
            }
            else if (choice == "3")
            {
                journal1.LoadEntries();
            }
            else if (choice == "4")
            {
                journal1.SaveEntries();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using Journal program.");
            }
            else
            {
                Console.WriteLine("That is not a valid option, plese enter a valid option.");
            }

        } while (choice != "5");


    }
}

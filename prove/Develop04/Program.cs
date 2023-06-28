using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listening Activity");
        Console.WriteLine("4. Quit");

        Console.Write("Select a choic from the menu: ");
        // string userInput = Console.ReadLine();

        ListActivity test = new ListActivity("act", "desc", 30);
        test.DisplayPromptL();

        test.ShowSpinner(10);
    }
}
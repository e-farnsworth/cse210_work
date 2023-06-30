public class Activity
{
    protected string _activity;
    protected string _description;
    protected int _durration;

    public Activity(string activity, string description)
    {
        _activity = activity;
        _description = description;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_activity} Activity");
        Console.WriteLine("");
        Console.WriteLine($"{_description}.");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        string durrationInput = Console.ReadLine();
        _durration = int.Parse(durrationInput);
    }

    public void EndMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_durration} seconds of the {_activity} Activity.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int secconds)
    {
        // Show the spinner
        // - \ | /
        for (int i = secconds; i > 0; i--)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b"); //Erases the previous character
            
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b"); //Erases the previous character

            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b"); //Erases the previous character
            
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b"); //Erases the previous character
        }
    }

    public void ShowCountdown(int secconds)
    {
        for (int i = secconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b"); //Erases the previous character
            
        }
        // Shows a countdown timer for in secconds
    }

    public int RandomIndex(int listLength)
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(1, listLength) - 1;
        return randomIndex;
    }
    
}
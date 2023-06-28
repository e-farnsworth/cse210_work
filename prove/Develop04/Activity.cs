public class Activity
{
    protected string _activity;
    protected string _description;
    private int _durration;

    public Activity(string activity, string description,int durration)
    {
        _activity = activity;
        _description = description;
        _durration = durration;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_activity} Activity");
        Console.WriteLine("");
        Console.WriteLine($"This activity will help you {_description}.");
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string durrationInput = Console.ReadLine();
        _durration = int.Parse(durrationInput);
        // Maybe return durration?
    }

    public void EndMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(10);
        Console.WriteLine($"You have completed another {_durration} of the {_activity} Activity.");
        ShowSpinner(10);
    }

    public void ShowSpinner(int secconds)
    {
        // Show the spinner
        // - \ | /
        for (int i = secconds; i > 0; i--)
        {
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b"); //Erases the previous character
            
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b"); //Erases the previous character

            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b"); //Erases the previous character
            
            Console.Write("/");
            Thread.Sleep(300);
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
}
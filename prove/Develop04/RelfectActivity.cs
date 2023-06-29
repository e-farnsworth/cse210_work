public class ReflectActivity : Activity
{
    
    public ReflectActivity(string activity, string description) : base(activity, description)
    {
        _activity = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public string ReflectPrompt()
    {
        string randomPrompt = "";
        // gets random reflection prompt
        return randomPrompt;
    }

    public string ReflectQuestion()
    {
        string randomQuestion = "";
        // gets random question about the prompt
        return randomQuestion;
    }

    public void DisplayPromptR()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {ReflectPrompt()} --- ");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("");
    }

    public void DisplayQuestion()
    {
        Console.WriteLine("Now ponder on each of the folowing questions as they relate to this experiance.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
    }

    public void RunReflectActivity()
    {
        StartMessage();
        Console.WriteLine("RUN ACTIVITY HERE");
        EndMessage();
    }
}
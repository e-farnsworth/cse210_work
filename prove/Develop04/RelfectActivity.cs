public class ReflectActivity : Activity
{
    
    public ReflectActivity(string activity, string description, int durration) : base(activity, description, durration)
    {
        
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
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);

        
    }
}
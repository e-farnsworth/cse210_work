public class ReflectActivity : Activity
{
    private List<string> questions = new List<string>
        {
            "Why was this experiance meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different that other times when you were not as successful?",
            "What is you favorite thing about this experiance?",
            "What could you learn from this experiance that applies to other situations?",
            "What did you learn about yourself through this experiance?",
            "How can you keep this experiance in mind in the future?"
        };
    
    public ReflectActivity(string activity, string description) : base(activity, description)
    {
        _activity = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public string ReflectPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truely selfless."
        };

        int _index = RandomIndex(prompts.Count());

        string randomPrompt = prompts[_index];
        // gets random reflection prompt
        return randomPrompt;
    }

    public string ReflectQuestion()
    {
        int _index = RandomIndex(questions.Count());

        string randomQuestion = questions[_index];
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

    public void RunReflectActivity()
    {
        StartMessage();
        DisplayPromptR();
        Console.WriteLine("Now ponder on each of the folowing questions as they relate to this experiance.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durration);
        
        DateTime currentTime = DateTime.Now;
        if (currentTime < endTime)
        {
            ReflectQuestion();
            ShowSpinner(3);
        }
        EndMessage();
    }
}
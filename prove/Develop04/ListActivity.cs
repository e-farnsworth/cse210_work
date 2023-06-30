public class ListActivity : Activity
{
    private string _listPromt;
    private List<string> _userResponses = new List<string>();
    public ListActivity(string activity, string description) : base(activity, description)
    {
        _activity = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public string ListPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that have you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heros?"
        };

        int _index = RandomIndex(prompts.Count());

        string randomPrompt = prompts[_index];
        // gets random reflection prompt
        return randomPrompt;
    }

    public void DisplayPromptL()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {ListPrompt()} --- ");
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);
    }

    public void RunListActivity()
    {
        StartMessage();

        DisplayPromptL();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durration);
        
        DateTime currentTime = DateTime.Now;
        if (currentTime < endTime)
        {
            Console.Write("> ");
            _userResponses.Add(Console.ReadLine());
        }
        Console.WriteLine($"You entered {_userResponses.Count()} items.");

        EndMessage();
    }
}
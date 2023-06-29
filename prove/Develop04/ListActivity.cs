public class ListActivity : Activity
{
    private string _listPromt;
    private List<string> _userResponse = new List<string>();
    public ListActivity(string activity, string description) : base(activity, description)
    {
        _activity = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public string ListPrompt()
    {
        string randomPrompt = "PROMPT";
        // gets random reflection prompt
        return randomPrompt;
    }

    public void SetResponses(string listResponse)
    {
        _userResponse.Add(listResponse);
        // Add responses to the list
    }

    public void DisplayPromptL()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {ListPrompt()} --- ");
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);

        Console.WriteLine("");
    }

    public void RunListActivity()
    {
        StartMessage();
        Console.WriteLine("RUN ACTIVITY HERE");
        EndMessage();
    }
}
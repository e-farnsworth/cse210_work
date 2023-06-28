public class ListActivity : Activity
{
    string _listPromt;
    List<string> _userResponse = new List<string>();
    public ListActivity(string activity, string description, int durration) : base(activity, description, durration)
    {
        
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
}
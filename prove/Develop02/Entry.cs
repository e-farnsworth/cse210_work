

public class Entry
{

    public string _newEntry;
    public string _date;
    public string _prompt;
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Promt: {_prompt}");
        Console.WriteLine($"Journal Entry: {_newEntry}");
    }
}
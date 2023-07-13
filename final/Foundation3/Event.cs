public abstract class Event
{
    protected string _eventType;
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Adress _adress;

    public Event(string eventTitle, string description, string date, string time, Adress adress)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _adress = adress;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"{_eventTitle}: ");
        Console.WriteLine(_description);
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine(_adress.PrintAdress());
        // Lists title, description, date, time, and adress

    }

    public abstract void FullDetails();

    public void ShortDescription()
    {
        Console.WriteLine($"{_eventType}: {_eventTitle}");
        Console.WriteLine($"{_date}\n");
    }

}
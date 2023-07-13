public class OutdoorEvent : Event
{
    private string _weather;
    public OutdoorEvent(string eventTitle, string description, string date, string time, Adress adress, string weather) : base(eventTitle, description, date, time, adress)
    {
        _eventType = "Outdoor";
        _weather = weather;
    }
    
    public override void FullDetails()
    {
        Console.WriteLine($"{_eventType}: {_eventTitle}");
        Console.WriteLine(_description);
        Console.WriteLine($"Predicted Weather COnditions: {_weather}");
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine(_adress.PrintAdress());
    }
}
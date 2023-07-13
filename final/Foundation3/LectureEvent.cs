public class LectureEvent : Event
{
    private string _speaker;
    private int _maxCapacity;
    public LectureEvent(string eventTitle, string description, string date, string time, Adress adress, string speaker, int capacity) : base(eventTitle, description, date, time, adress)
    {
        _eventType = "Lecture";
        _speaker = speaker;
        _maxCapacity = capacity;
    }

    public override void FullDetails()
    {
        Console.WriteLine($"{_eventType}: {_eventTitle}");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine(_description);
        Console.WriteLine($"Venue Capacity: {_maxCapacity}");
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine(_adress.PrintAdress());
    }
}
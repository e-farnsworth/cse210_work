public class ReceptionEvent : Event
{
    string _emailRSVP;
    public ReceptionEvent(string eventTitle, string description, string date, string time, Adress adress, string email) : base(eventTitle, description, date, time, adress)
    {
        _eventType = "Reception";
        _emailRSVP = email;
    }

    public override void FullDetails()
    {
        Console.WriteLine($"{_eventType}: {_eventTitle}");
        Console.WriteLine(_description);
        Console.WriteLine($"RSVP: {_emailRSVP}");
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine(_adress.PrintAdress());
    }
}
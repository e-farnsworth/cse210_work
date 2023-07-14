public class Activity
{
    // track date and length of activity (minutes)
    // Running: track distance
    // Cycling: track speed
    // Swimming: track laps
    private string _date;
    private int _minutes;
    protected string _activity;
    protected double _distance;
    protected double _speed;
    protected double _pace;


    // Get for each: distance, speed (mph or kph), pace (min per mile / km)
    // summary: Date, activity (length)- distance, speed, pace
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual void CalculateDistance()
    {
        _distance = _speed * _minutes / 60;
    }

    public void CalculateSpeed()
    {
        _speed = (_distance / _minutes) * 60;
    }

    public virtual void CalculatePace()
    {
        _pace = _minutes / _distance;
    }

    public void GetSummary()
    {
        Console.WriteLine(
            $"{_date} {_activity} ({_minutes} min) - Distance: {Math.Round(_distance,2)} km, Speed: {Math.Round(_speed,2)} kph, Pace: {Math.Round(_pace,2)} min per km"
        );
    }
}
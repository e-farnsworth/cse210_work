public class BikingActivity : Activity
{
    public BikingActivity(string date, int  minutes, double speed) : base(date, minutes)
    {
        _activity = "Biking";
        _speed = speed;
        CalculateDistance();
        CalculatePace();
    }

    public override void CalculatePace()
    {
        _pace = 60 / _speed;
    }
}
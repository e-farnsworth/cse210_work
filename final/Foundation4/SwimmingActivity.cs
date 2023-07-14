public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(string date, int  minutes, int laps) : base(date, minutes)
    {
        _activity = "Swimming";
        _laps = laps;
        CalculateDistance();
        CalculateSpeed();
        CalculatePace();
    }

    public override void CalculateDistance()
    {
        _distance = _laps * 50 / 1000;
    }
}
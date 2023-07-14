public class RunningActivity : Activity
{
    public RunningActivity(string date, int minutes, double distance) : base(date, minutes)
    {
        _activity = "Running";
        _distance = distance;
        CalculateSpeed();
        CalculatePace();
    }
}
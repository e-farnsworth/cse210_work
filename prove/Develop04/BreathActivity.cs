public class BreathActivity : Activity
{
    public BreathActivity(string activity, string description) : base(activity, description)
    {
        _activity = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void DisplayBreathing()
    {
        Console.Write("Breath in ...");
        ShowCountdown(5);
        Console.WriteLine("");
        Console.Write("Breath out ...");
        ShowCountdown(5);
    }

    public void RunBreathActivity()
    {
        StartMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durration);

        DateTime currentTime = DateTime.Now;
        if (currentTime < endTime)
        {
            DisplayBreathing();
        }

        EndMessage();
    }
}
public class BreathActivity : Activity
{
    public BreathActivity(string activity, string description) : base(activity, description)
    {
        _activity = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunBreathActivity()
    {
        StartMessage();
        Console.WriteLine("RUN ACTIVITY HERE");
        EndMessage();
    }
}
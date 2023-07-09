public class EternalGoal : Goal
{
    public EternalGoal(string goalDescription, int pointCompletion) : base(goalDescription, pointCompletion)
    {

    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}
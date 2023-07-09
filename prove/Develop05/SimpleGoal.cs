public class SimpleGoal : Goal
{
    private bool _complete;
    public SimpleGoal(string goalDescription, int pointCompletion) : base(goalDescription, pointCompletion)
    {
        _complete = false;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
        // _goalComplete = ture;
    }
}
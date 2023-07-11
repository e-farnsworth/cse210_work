public class EternalGoal : Goal
{
    public EternalGoal(string goalType, string goalName, string goalDescription, int pointCompletion) : base(goalType, goalName, goalDescription, pointCompletion)
    {
        _goalType = "eternal";
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}
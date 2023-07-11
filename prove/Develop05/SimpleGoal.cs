public class SimpleGoal : Goal
{
    private bool _complete;
    public SimpleGoal(string goalType, string goalName, string goalDescription, int pointCompletion) : base(goalType, goalName, goalDescription, pointCompletion)
    {
        _complete = false;
        _goalType = "simple";
    }

    public SimpleGoal(string goalType, string goalName, string goalDescription, bool complete, int pointCompletion) : base(goalType, goalName, goalDescription, pointCompletion)
    {
        _complete = complete;
        _goalType = "simple";
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
        // _complete = ture;
    }

    public override string GetGoalStatus()
    {
        if (_complete == true)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

    public override string GetGoalNameAndDescription()
    {
        return $"{_goalType}||{_goalName}||{_goalDescription}||{_complete}";
    }

}
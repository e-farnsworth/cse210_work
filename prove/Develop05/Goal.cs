public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _points;
    protected int _pointsTotal;
    protected string _goalType;

    public Goal(string goalType, string goalName, string goalDescription, int pointValue)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = pointValue;
        _goalType = goalType;
    }

    public void SetPointTotal(int pointsTotal)
    {
        _pointsTotal = pointsTotal;
    }

    public abstract void RecordEvent();

    public int GetTotalPoints()
    {
        return _pointsTotal;
    }

    public virtual string GetGoalNameAndDescription()
    {
        return $"{_goalType}||{_goalName}||{_goalDescription}";
    }

    public virtual string GetGoalPoints()
    {
        return $"{_points}";
    }

    public virtual string GetGoalStatus()
    {
        return "";
    }
    
}
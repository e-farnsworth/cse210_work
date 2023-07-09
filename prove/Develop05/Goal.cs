public abstract class Goal
{
    private string _goal;
    private int _points;
    private int _pointsTotal;

    public Goal(string goalDescription, int pointValue)
    {
        _goal = goalDescription;
        _points = pointValue;
    }

    public abstract void RecordEvent();
}
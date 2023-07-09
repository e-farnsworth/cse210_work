public class ChecklistGoal : Goal
{
    private int _goalLength; //How many times the goal needs to be met
    private int _pointStep; //Points alloted for completing a check
    private int _currentStep; //how many times the goal has been completed
    public ChecklistGoal(string goalDescription, int goalSteps, int pointCompletion, int pointStep) : base(goalDescription, pointCompletion)
    {
        _goalLength = goalSteps;
        _pointStep = pointStep;
        _currentStep = 0;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
        // Add 1 to the counter if _currentStep != _goalLength
        // else congradulates that the gola is complete
    }
}
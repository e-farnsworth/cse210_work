public class ChecklistGoal : Goal
{
    private int _goalLength; //How many times the goal needs to be met
    private int _pointStep; //Points alloted for completing a check
    private int _currentStep; //how many times the goal has been completed
    public ChecklistGoal(string goalType, string goalName, string goalDescription, int goalSteps, int pointCompletion, int pointStep) : base(goalType, goalName, goalDescription, pointCompletion)
    {
        _goalLength = goalSteps;
        _pointStep = pointStep;
        _currentStep = 0;
        _goalType = "checklist";
    }

    public ChecklistGoal(string goalType, string goalName, string goalDescription, int goalSteps, int currentStep, int pointCompletion, int pointStep) : base(goalType, goalName, goalDescription, pointCompletion)
    {
        _goalLength = goalSteps;
        _pointStep = pointStep;
        _currentStep = currentStep;
        _goalType = "checklist";
    }

    public override string GetGoalStatus()
    {
        return $"[{_currentStep}/{_goalLength}]";
    }

    public override void RecordEvent()
    {
        if (_currentStep != _goalLength)
        {
            _currentStep ++;
            _pointsTotal += _pointStep;
            if (_currentStep == _goalLength)
            {
                _pointsTotal += _points;
                Console.WriteLine("Congradulations, you have completed this goal!");
            }
            else
            {
                Console.WriteLine("You are one step closer to completing this goal!");
            }
        }
        else
        {
            Console.WriteLine("You have already completed this goal");
        }
    }

    public override string GetGoalNameAndDescription()
    {
        return $"{_goalType}||{_goalName}||{_goalDescription}||{_goalLength}||{_currentStep}";
    }

    public override string GetGoalPoints()
    {
        return $"{_points}||{_pointStep}";
    }
}
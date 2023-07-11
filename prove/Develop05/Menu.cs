public class Menu
{
    
    private string _fileName;
    private Goal _goal;
    private List<Goal> _goals = new List<Goal>();

    public void NewGoal()
    {
        // goal type and add it to the list
    }

    public void SaveGoals()
    {
        
        Console.WriteLine("Enter the filename to save your goals (example.txt):");
        _fileName = Console.ReadLine(); 

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            // You can add text to the file with the WriteLine method
            foreach (Goal _goal in _goals)
            {
                outputFile.WriteLine($"{_goal.GetGoalNameAndDescription()}||{_goal.GetGoalPoints()}");
            }
            outputFile.WriteLine($"{_goal.GetTotalPoints()}");
        }
        Console.WriteLine("Journal Saved Succesfully.");
    }

    public void LoadGoals()
    {
        

        Console.WriteLine("Enter the filename to load the journal (example.txt):");
        _fileName = Console.ReadLine();
        
        _goals.Clear();
        
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            Goal _goal;
            string[] parts = line.Split("||");
            
            if (parts[0] == "eternal")
            {
                _goal = new EternalGoal("", parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(_goal);
            }
            else if (parts[0] == "simple")
            {
                _goal = new SimpleGoal("",parts[1], parts[2],bool.Parse(parts[3]),int.Parse(parts[4]));
                _goals.Add(_goal);
            }
            else if (parts[0] == "checklist")
            {
                _goal = new ChecklistGoal("",parts[1], parts[2],int.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(_goal);
            }
            else
            {
                _goal = new Goal(int.Parse(parts[0]));
            }
            
        }

        Console.WriteLine("Journal Loaded Succesfully.");
    }

    public void UpdateGoals()
    {
        // record event
    }
}
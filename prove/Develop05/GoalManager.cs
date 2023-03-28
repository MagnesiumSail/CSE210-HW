public class GoalManager
{
    public List<Goal> _goals;
    private int points;

    public GoalManager()
    {
        _goals = new List<Goal>();
        points = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void IncrementChecklistGoal(ChecklistGoal goal)
    {
        goal.IncrementCount();
        points += goal._value;

        if (goal._IsCompleted)
        {
            points += goal.BonusPoints;
        }
    }

    public void DisplayGoals()
    {
        int i = 1;
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.Write($"{i}. ");
            Console.WriteLine(goal.ToString());
            i++;
        }
    }
    public void CreateGoal(string name, string description, int value, int goalType)
    {
        Goal newGoal = null;

        switch (goalType) 
        {
            case 1:
                newGoal = new SimpleGoal(name, description, value);
                break;
            case 2:
                newGoal = new EternalGoal(name, description, value);
                break;
            default:
                Console.WriteLine("Invalid goal type");
                break;
        }

        if (newGoal != null) 
        {
            this.AddGoal(newGoal);
            Console.WriteLine("Goal created successfully!");
        }
    }
    public void CreateGoal(string name, string description, int value, int goalType, int listCount, int bonusPoints)
    {
        Goal newGoal = new ChecklistGoal(name, description, value, listCount, bonusPoints);
        if (newGoal != null) 
        {
            this.AddGoal(newGoal);
            Console.WriteLine("Goal created successfully!");
        }
    }

    public void RecordEvent()
    {
    Console.WriteLine("Enter the number of the goal you want to update:");
    int goalNumber = int.Parse(Console.ReadLine()) - 1;


        if (_goals[goalNumber]._type == "Simple")
        {
            _goals[goalNumber]._IsCompleted = true;
            points = _goals[goalNumber].AwardPoints();
        }
        if (_goals[goalNumber]._type == "Eternal")
        {
            points = _goals[goalNumber].AwardPoints();
        }
        if (_goals[goalNumber]._type == "Checklist")
        {
            ChecklistGoal checklistGoal = (ChecklistGoal)_goals[goalNumber];
            this.IncrementChecklistGoal(checklistGoal);
            if (checklistGoal.CurrentCount == checklistGoal.listCount)
            {
                checklistGoal._IsCompleted = true;
            }
        }
    }
    public int getPoints()
    {
        return points;
    }
}

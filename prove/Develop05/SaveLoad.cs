public class GoalFileManager
{
    private string _filename;
    
    public GoalFileManager(string filename)
    {
        _filename = filename;
    }
    
    public void SaveGoals(List<Goal> goals)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(_filename))
            {
                foreach (Goal goal in goals)
                {
                    string goalData = $"{goal._type},{goal._name},{goal._description},{goal._value},{goal._IsCompleted}";

                    if (goal is ChecklistGoal)
                    {
                        ChecklistGoal cg = (ChecklistGoal)goal;
                        goalData += $",{cg.listCount},{cg.CurrentCount},{cg.BonusPoints}";
                    }

                    sw.WriteLine(goalData);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals to file {_filename}: {ex.Message}");
        }
    }
    
    public List<Goal> LoadGoals()
    {
        List<Goal> goals = new List<Goal>();
        
        try
        {
            using (StreamReader sr = new StreamReader(_filename))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] goalData = line.Split(',');

                    string type = goalData[0];
                    string name = goalData[1];
                    string description = goalData[2];
                    int value = int.Parse(goalData[3]);
                    bool isCompleted = bool.Parse(goalData[4]);

                    Goal goal = null;

                    if (type == "Simple")
                    {
                        goal = new SimpleGoal(name, description, value);
                    }
                    else if (type == "Eternal")
                    {
                        goal = new EternalGoal(name, description, value);
                    }
                    else if (type == "Checklist")
                    {
                        int listCount = int.Parse(goalData[5]);
                        int currentCount = int.Parse(goalData[6]);
                        int bonusPoints = int.Parse(goalData[7]);

                        goal = new ChecklistGoal(name, description, value, listCount, bonusPoints);
                        ((ChecklistGoal)goal).CurrentCount = currentCount;
                    }

                    goal._IsCompleted = isCompleted;
                    goals.Add(goal);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals from file {_filename}: {ex.Message}");
        }
        
        return goals;
    }
}

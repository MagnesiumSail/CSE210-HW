public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int value) : base(name, description, "Simple", value)
    {
        _IsCompleted = false;
    }

    public void CompleteGoal()
    {
        if (!_IsCompleted)
        {
            _IsCompleted = true;
        }
    }

    public override int AwardPoints()
    {
        if (_IsCompleted)
        {
            return _value;
        }
        return 0;
    }

    public override string ToString()
    {
        return $"[{(_IsCompleted ? "X" : " ")}] {_name} ({_description}) - {_value} points";
    }
}

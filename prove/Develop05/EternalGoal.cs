public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int value) : base(name, description, "Eternal", value)
    {

    }

    public override int AwardPoints()
    {
        return _value;
    }
    public override string ToString()
    {
        return $"[{(_IsCompleted ? "X" : " ")}] {_name} ({_description}) - {_value} points";
    }
}
public abstract class Goal
{
    public string _name;
    public string _description;
    public string _type;
    public int _value;
    public bool _IsCompleted;
    public Goal(string name, string description, string type, int value)
    {
        _name = name;
        _description = description;
        _type = type;
        _value = value;
    }
    public abstract int AwardPoints();
    public abstract string ToString();
}

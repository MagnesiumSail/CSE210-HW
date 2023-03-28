public class ChecklistGoal : Goal
{
    public int listCount;
    public int CurrentCount;
    public int BonusPoints;

    public ChecklistGoal(string name, string description, int value, int listCount, int bonusPoints) : base(name, description, "Checklist", value)
    {
        this.listCount = listCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public void IncrementCount()
        {
            if (!_IsCompleted)
            {
                CurrentCount++;
            }
        }

    public override int AwardPoints()
        {
            return BonusPoints;
        }

    public override string ToString()
    {
        return $"[{(_IsCompleted ? "X" : " ")}] {_name} ({_description}) - {_value} points per completion, {BonusPoints} bonus points - {CurrentCount}/{listCount} completed";
    }
}

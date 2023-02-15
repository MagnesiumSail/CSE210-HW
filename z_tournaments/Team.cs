public class Team
{
    private string _name = "";
    private List<Player> _roster = new List<Player>();
    private int _wins = 0;
    private int _losses = 0;

    public Team(string name)
    {
        _name = name;
    }

    public void addPlayer(Player p)
    {
        _roster.Add(p);
    }

    public void displayRoster()
    {
        Console.WriteLine();
        Console.WriteLine(_name);
        Console.WriteLine($"Wins: {_wins}||| Losses: {_losses}");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        foreach (Player p in _roster)
        {
            p.Display();
        }
        Console.WriteLine();
    }

    public void addWin()
    {
        _wins += 1;
    }
    public void addLoss()
    {
        _losses += 1;
    }
    public string getTeamName()
    {
        return _name;
    }

}
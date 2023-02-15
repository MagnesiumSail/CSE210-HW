public class Match
{
    private Team _team1;
    private Team _team2;

    public Match(Team team1, Team team2)
    {
        _team1 = team1;
        _team2 = team2;
    }

    public void DecideWin()
    {
        Console.WriteLine("Which Team Won?");
        Console.WriteLine($"1:{_team1.getTeamName()}");
        Console.WriteLine($"2:{_team2.getTeamName()}");

        string winner = Console.ReadLine();
        
        if(winner == "1")
        {
            _team1.addWin();
            _team2.addLoss();
        }
        else
        {
            _team1.addLoss();
            _team2.addLoss();
        }
    }

}
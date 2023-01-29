public class Entry
{
    public string _Date = "";
    public string _Prompt = "";
    public string _UserText = "";

    RandoPrompt randoprompt = new RandoPrompt();
    
    public void addEntry()
    {
        string bread = "";
        bread = randoprompt.RandomPrompts(bread);
        Console.WriteLine(bread);
        _UserText = Console.ReadLine();
        _Prompt = bread;
        DateTime theCurrentTime = DateTime.Now;
        _Date = theCurrentTime.ToShortDateString();
    }

}
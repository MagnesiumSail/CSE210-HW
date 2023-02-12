class Scripture
{
    private List<string> verses; 
    private string title = "Proverbs 3:5-6";

    public Scripture()
    {
        verses = new List<string>
        {
            "Trust",
            "in",
            "the",
            "Lord",
            "with",
            "all",
            "thine",
            "heart",
            "and",
            "lean",
            "not",
            "unto",
            "thine",
            "own",
            "understanding;",
            "in",
            "all",
            "thy",
            "ways",
            "acknowledge",
            "him",
            "and",
            "he",
            "shall",
            "direct",
            "thy",
            "paths."
        };
    }
    public int scriptureCount()
    {
        return verses.Count();
    }

    public List<string> getVerses()
    {
        return verses;
    }
    public int totalMaxWords()
    {
        return (verses.Count()/3) + 1;
    }
    public string getTitle()
    {
        return title;
    }
    /*public void loadScripture()
    {
        Console.WriteLine("Filename: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        title = lines[0].Trim();
        for (int i = 1; i < lines.Length; i++)
        {
            verses.Add(lines[i]);
        }
    }*/
}
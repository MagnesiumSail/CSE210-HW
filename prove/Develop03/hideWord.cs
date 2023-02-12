class SetUpBoolean
{
    private List<bool> toggleWord;
    private List<int> remember = new List<int>();
    int count = 0;
    public SetUpBoolean(List<string> scripture, int _count)
    {
        count = _count;
        toggleWord = new List<bool>(count);
        for (int x = 0; x < count; x++)
        {
            toggleWord.Add(true);
            remember.Add(x);
        }
    }

    public void hideThreeWords()
    {
        int randomNumber = 0;
        Random rnd = new Random();
        
        for (int y = 0; y < 3; y++)
        {
            bool areAllFalse = toggleWord.All(x => x == false);
            do
            {
                randomNumber = rnd.Next(count);
            }   while (!remember.Contains(randomNumber) && areAllFalse == false);
            toggleWord[randomNumber] = false;
            remember.Remove(randomNumber);
        }
    }
    public List<bool> getBooleanList()
    {
        return toggleWord;
    }




    /*
    public void testDisplay()
    {
        foreach(string x in scriptureHide)
        {
            Console.WriteLine(x);
        }
        scriptureHide[3] = "switchTest";
        foreach(string y in scriptureHide)
        {
            Console.WriteLine(y);
        }
    }*/

    
}
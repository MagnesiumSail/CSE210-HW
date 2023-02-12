class Display
{
    public Display()
    {

    }

    private void DisplayScripture(List<string> _verses, List<bool> _toggleWord, int _count, string title)
    {
        Console.WriteLine();
        Console.Write($"{title} ");
        for (int x = 0; x < _count; x++)
        {
            if (_toggleWord[x] == true)
            {
                Console.Write($"{_verses[x]} ");
            }
            else
            {
                string underscores = new string('_', _verses[x].Length);
            Console.Write(underscores.PadRight(_verses[x].Length + 1));
            }
        }
    }

    public void loopThroughDisplays(int loops, List<string> _verses, List<bool> _toggleWord, int _count, SetUpBoolean _hideWord2, string title)
    {
        for (int l = 0; l < loops + 1; l++)
        {
            //Console.Clear();
            if (!_toggleWord.Contains(true))
            {
                l++;
            }
            DisplayScripture(_verses, _toggleWord, _count, title);
            Console.WriteLine("\nPlease enter to continue or type 'quit' to finish:");
            string quit = Console.ReadLine();
            if (quit == "quit")
            {
                break;
            }
            _hideWord2.hideThreeWords();

        }
    }
}
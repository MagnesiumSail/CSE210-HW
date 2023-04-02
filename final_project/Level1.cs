class Level1 : GameBoard
{
    public Level1(int dBot, int dTop) : base(dBot, dTop)
    {

    }
    public override void initializeBoard()
    {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    char c = buffer[x, y];
                    if (c == '♦' && y == _dBot)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (c == '♦' && y == _dBot + 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (c == '♦' && y == _dBot + 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.Write(c);
                }
                Console.WriteLine();
            }
    }
}
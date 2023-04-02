class Level3 : GameBoard
{
    public Level3(int dTop, int dBot) : base(dTop, dBot)
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
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (c == '♦' && y == _dBot + 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
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
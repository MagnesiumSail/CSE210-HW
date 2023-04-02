public abstract class GameBoard
{
    private const int Width = 48;
    public int _width = Width;
    private const int Height = 14;
    public int _height = Height;
    protected int _dTop;
    protected int _dBot;
    public char[,] buffer = new char[Width, Height];
    public GameBoard(int dBot, int dTop)
    {
        _dTop = dTop;
        _dBot = dBot;
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                if (x == 0 || x == Width - 1|| y == 0 || y == Height - 1)
                {
                    buffer[x, y] = '#';
                }
                else if (y <= _dTop && y >= _dBot)
                {
                    buffer[x, y] = '♦';
                }
                else
                {
                    buffer[x, y] = ' ';
                }
            }
        }

        Console.Clear();
        Console.SetCursorPosition(0, 0);
    }
    public virtual void initializeBoard()
    {
            
    }
}
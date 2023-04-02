public abstract class Block
{
    public Block()
    {

    }
    public static void clearBlock(GameBoard board, Engine engine, int X, int Y)
    {
        if(board.buffer[X, Y] == '♦')
            {
                board.buffer[X, Y] = ' ';
                Console.SetCursorPosition(X, Y);
                Console.Write(board.buffer[X, Y]);
                Engine.checkForWin(board, engine);
            }
    }
}
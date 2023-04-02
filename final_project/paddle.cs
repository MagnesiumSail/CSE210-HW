public class Paddle
{
    int pLeft;
    int pRight;
    public char[] paddLine;
    public Paddle(GameBoard board, int _pLeft, int _pRight)
    {
        pLeft = _pLeft;
        pRight = _pRight;
        paddLine = new char[board._width];
        for(int i = 0; i < board._width; i++)
        {
            if (i == 0 || i == board._width - 1)
            {
                paddLine[i] = '#';
            }
            else if(i == pLeft || i == pRight)
            {
                paddLine[i] = '+';
            }
            else if(i > pLeft && i < pRight)
            {
                paddLine[i] = '-';
            }
            else
            {
                paddLine[i] = ' ';
            }
        }
    }

    public void drawPaddle(GameBoard board)
    {
        Console.SetCursorPosition(pLeft - 1, board._height - 2);
        for(int i = pLeft - 1; i <= pRight + 1; i++)
        {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(paddLine[i]);
        }
        Console.ForegroundColor = ConsoleColor.Black;
    }

    public void updatePaddle(GameBoard board, ConsoleKey arrowKey)
    {
        if (pLeft > 1 && arrowKey == ConsoleKey.LeftArrow)
        {
            pLeft--;
            pRight--;
        }
        else if (pRight < board._width - 2 &&arrowKey == ConsoleKey.RightArrow)
        {
            pLeft++;
            pRight++;
        }

        for(int i = 1; i < board._width - 1; i++)
        {
            if(i == pLeft || i == pRight)
            {
                paddLine[i] = '+';
            }
            else if(i > pLeft && i < pRight)
            {
                paddLine[i] = '-';
            }
            else
            {
                paddLine[i] = ' ';
            }
        }
        
        
    }

}
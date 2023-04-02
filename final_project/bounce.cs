public class Bounce : Ball
{
    public Bounce(int x, int y) : base(x, y)
    {

    }
    public bool checkCardinals(GameBoard board, Paddle _paddle, Engine engine)
    {
        bool hit = false;
        //check above
        if (board.buffer[ballX, ballY - 1] != ' ')
        {
            Block.clearBlock(board, engine, ballX, ballY - 1);           
            Down();
            hit = true;
        }
        //check below
        if (board.buffer[ballX, ballY + 1] != ' ')
        {
            Block.clearBlock(board, engine, ballX, ballY + 1);
            Up();
            hit = true;
        }
        //check right side
        if (currentDirection[0] == 1 && board.buffer[ballX + 1, ballY] != ' ')
        {
            Block.clearBlock(board, engine, ballX + 1, ballY);
            Left();
            hit = true;
        }
        //check left side
        if (currentDirection[0] == -1 && board.buffer[ballX - 1, ballY] != ' ')
        {
            Block.clearBlock(board, engine, ballX - 1, ballY);
            Right();
            hit = true;
        }
        return hit;
    }

    public void checkCorners(GameBoard board, Paddle _paddle, Engine engine)
    {
        //getDirection
        if(currentDirection[0] == 1 && currentDirection[1] == 1)
        {
            //check bottom right
            if (board.buffer[ballX + 1, ballY + 1] != ' ')
            {
                Block.clearBlock(board, engine, ballX + 1, ballY + 1);           
                Up();
                Left();
            }
        }
        if(currentDirection[0] == -1 && currentDirection[1] == -1)
        {
            //check top left
            if (board.buffer[ballX - 1, ballY - 1] != ' ')
            {
                Block.clearBlock(board, engine, ballX - 1, ballY - 1);           
                Down();
                Right();
            }
        }
        if(currentDirection[0] == 1 && currentDirection[1] == -1)
        {
            //check top right
            if (board.buffer[ballX + 1, ballY - 1] != ' ')
            {
                Block.clearBlock(board, engine, ballX + 1, ballY - 1);           
                Down();
                Left();
            }
        }
        if(currentDirection[0] == -1 && currentDirection[1] == 1)
        {
            //check bottom left
            if (board.buffer[ballX - 1, ballY + 1] != ' ')
            {
                Block.clearBlock(board, engine, ballX - 1, ballY + 1);           
                Up();
                Right();
            }
        }
    }
    public void checkPaddle(Paddle _papple, int X)
    {
        //check below
        if(_papple.paddLine[X] == '-' || _papple.paddLine[X] == '+')
        {
            Up();
        }
        //check corners
        if(_papple.paddLine[X + currentDirection[0]] == '+')
        {
            Up();
            currentDirection[0] = -currentDirection[0];
        }
    }
}







        /*
        
        */ 

        /*public void checkNineSquare(GameBoard board)
    {
        for (int _x = ballX - 1; _x <= ballX + 1; _x++)
        {
            for (int _y = ballY - 1; _y <= ballY + 1; _y++)
            {
                checkCollision(board, _x, _y);
            }
        }
    }
    */

    /*// Check if square is within board bounds
        if (_x >= 0 && _x < board._width && _y >= 0 && _y < board._height)
        {
            //Check if square contains anything
            if (board.buffer[_x, _y] != ' ')
            {
                bool horizontalCollision = _x == ballX + currentDirection[0] && _y == ballY;
            bool verticalCollision = _y == ballY + currentDirection[1] && _x == ballX;
            bool diagonalCollision = _x == ballX + currentDirection[0] && _y == ballY + currentDirection[1];

            // Check for ball direction
            if (horizontalCollision && !verticalCollision)
            {
                flipLR();
            }
            else if (verticalCollision && !horizontalCollision)
            {
                flipUD();
            }
            else if (diagonalCollision)
            {
                bool horizontalAdjacentOccupied = board.buffer[ballX + currentDirection[0], ballY] != ' ';
                bool verticalAdjacentOccupied = board.buffer[ballX, ballY + currentDirection[1]] != ' ';

                if (!horizontalAdjacentOccupied && !verticalAdjacentOccupied)
                {
                    flipLR();
                    flipUD();
                }
                else if (horizontalAdjacentOccupied)
                {
                    flipUD();
                }
                else if (verticalAdjacentOccupied)
                {
                    flipLR();
                }
            }
            }
        }*/
public class Engine
{
    bool _running = true;
    int ballCounter = 0;
    int ballSpeed;
    const int delayMs = 80; // set the paddle delay
    bool leftArrowPressed = false;
    bool rightArrowPressed = false;
    DateTime lastKeyPressTime = DateTime.Now;
    public Engine(int _ballspeed)
    {
        ballSpeed = _ballspeed;
    }

    public void gameRunning(GameBoard board, Ball ball, Paddle paddle)
    {
        while(_running == true)
        {
            if (ball is Bounce bounce)
            {
                if(ball.ballY == board._height - 3)
                {
                    bounce.checkPaddle(paddle, ball.ballX);
                }
                if (ball.ballX == 0 || ball.ballX == board._width - 1 || ball.ballY == 0 || ball.ballY == board._height - 1)
                {
                    ball.ballX = 24;
                    ball.ballY = 3;
                }
                else if(bounce.checkCardinals(board, paddle, this) == false)
                    {
                        bounce.checkCorners(board, paddle, this);
                    }
            }
            checkArrowKeys(board, paddle);
            paddle.drawPaddle(board);
            if (ballCounter > ballSpeed)
            {
            clearBall(board, ball);
            ball.moveBall();
            drawBall(board, ball);
            ballCounter = 0;
            }
            Console.SetCursorPosition(0, 0);
            checkForLoss(board, ball);
            ballCounter++;
        }
    }

    private void drawBall(GameBoard board, Ball ball)
    {
        Console.SetCursorPosition(ball.ballX, ball.ballY);
        board.buffer[ball.ballX, ball.ballY] = '@';
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(board.buffer[ball.ballX, ball.ballY]);
        Console.ForegroundColor = ConsoleColor.Black;
    }
    private void clearBall(GameBoard board, Ball ball)
    {
        Console.SetCursorPosition(ball.ballX, ball.ballY);
        board.buffer[ball.ballX, ball.ballY] = ' ';
        Console.Write(board.buffer[ball.ballX, ball.ballY]);
    }
    private void checkForLoss(GameBoard board, Ball ball)
    {
        if(ball.ballY == board._height - 2)
        {
            Console.SetCursorPosition(15, 8);
            Console.WriteLine("YOU LOSE NERD!");
            Thread.Sleep(5000);
            _running = false;
        }
    }
    private void checkArrowKeys(GameBoard board, Paddle _paddle)
    {
        if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    if (!leftArrowPressed && DateTime.Now - lastKeyPressTime > TimeSpan.FromMilliseconds(delayMs))
                    {
                        leftArrowPressed = true;
                        _paddle.updatePaddle(board, keyInfo.Key);
                        lastKeyPressTime = DateTime.Now;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    if (!rightArrowPressed && DateTime.Now - lastKeyPressTime > TimeSpan.FromMilliseconds(delayMs))
                    {
                        rightArrowPressed = true;
                        _paddle.updatePaddle(board, keyInfo.Key);
                        lastKeyPressTime = DateTime.Now;
                    }
                }
            }
        else
        {
            if (leftArrowPressed)
            {
                leftArrowPressed = false;
            }
            if (rightArrowPressed)
            {
                rightArrowPressed = false;
            }
        }
        Thread.Sleep(2);
    }         

    public static bool checkForWin(GameBoard board, Engine engine)
    {
        for (int x = 0; x < board._width; x++)
        {
            for (int y = 0; y < board._height; y++)
            {
                if (board.buffer[x, y] == '♦')
                {
                    return false;
                }
            }
        }
        engine._running = false;
        Console.SetCursorPosition(15, 8);
        Console.WriteLine("YOU WIN NERD!");
        Thread.Sleep(5000);
        return true;
    }
}
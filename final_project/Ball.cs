public class Ball
{
    public int ballX;
    public int ballY;
    protected int[] currentDirection = {-1,1};
    char lastCharacter;
    public Ball(int x, int y)
    {
        ballX = x;
        ballY = y;
    }

    protected void Right()
    {
        currentDirection[0] = 1;
    }
    protected void Left()
    {
        currentDirection[0] = -1; 
    }
    protected void Up()
    {
        currentDirection[1] = -1;
    }
    protected void Down()
    {
        currentDirection[1] = 1;
    }



    public void moveBall()
    {
        ballX += currentDirection[0];
        ballY += currentDirection[1];
    }
}
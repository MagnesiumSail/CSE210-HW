class Menu
{
    public bool Display()
    {
        Console.Clear();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine(" Welcome to Terminal Breakout!");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Level One");
        Console.WriteLine("2. Level Two");
        Console.WriteLine("3. Level Three");
        Console.WriteLine("4. Controls");
        Console.WriteLine("5. Explanation");
        Console.WriteLine("6. Quit");

        switch (GetChoice())
        {
            case 1:
                LevelOne();
                break;
            case 2:
                LevelTwo();
                break;
            case 3:
                LevelThree();
                break;
            case 4:
                Controls();
                break;
            case 5:
                Explanation();
                break;
            case 6:
                return true;
        }
        return false;
    }

    private int GetChoice()
    {
        Console.Write("Enter your choice: ");
        int choice = 0;
        choice = int.Parse(Console.ReadLine());
        return choice;
    }

    private void LevelOne()
    {
        Level1 LevelOne = new Level1(3, 5);
        Engine game = new Engine(22);
        Bounce ball = new Bounce(12, 7);
        Paddle paddle = new Paddle(LevelOne, 4, 9);
        LevelOne.initializeBoard();
        game.gameRunning(LevelOne, ball, paddle);
    }

    private void LevelTwo()
    {
        Level2 LevelTwo = new Level2(3, 6);
        Engine game = new Engine(17);
        Bounce ball = new Bounce(12, 7);
        Paddle paddle = new Paddle(LevelTwo, 4, 6);
        LevelTwo.initializeBoard();
        game.gameRunning(LevelTwo, ball, paddle);
    }

    private void LevelThree()
    {
        Level3 LevelThree = new Level3(3, 4);
        Engine game = new Engine(7);
        Bounce ball = new Bounce(12, 7);
        Paddle paddle = new Paddle(LevelThree, 4, 11);
        LevelThree.initializeBoard();
        game.gameRunning(LevelThree, ball, paddle);
    }

    private void Controls()
    {
        Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine(" <- Left Arrow Key || Move Left");
        Console.WriteLine(" -> Right Arrow Key || Move Right");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
    }

    private void Explanation()
    {
        Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("This is a remake of Atari Breakout in terminal");
        Console.Write("Move the \"");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("+---+");
        Console.ResetColor();
        Console.Write("\" paddle underneath the \"");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("@");
        Console.ResetColor();
        Console.WriteLine("\" ball");
        Console.Write("to bounce it into the \"");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("♦");
        Console.ResetColor();
        Console.WriteLine("\" blocks to pop them.");
        Console.WriteLine("Pop them all to win!");
        Console.Write("Let the ball touch the floor and lose...");
        Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
        
    }
}

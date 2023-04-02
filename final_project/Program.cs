class Program
{
    static void Main(string[] args)
    {
        //Console.TreatControlCAsInput = true;
        Menu menu1 = new Menu();
        bool quit = false;
        do{
            quit = menu1.Display();
        }   while (quit == false);
        
    }
}


/*
//GameBoard gameboard = new GameBoard();
        //Engine game = new Engine();
        //Bounce ball = new Bounce(14, 7);
        //Paddle paddle = new Paddle(gameboard);
        //gameboard.initializeBoard();
        //game.gameRunning(gameboard, ball, paddle)
        ConsoleKeyInfo keyInfo;

        Console.WriteLine("Press any key to continue...");

        do
        {
            keyInfo = Console.ReadKey();
            Console.WriteLine("You pressed the '{0}' key", keyInfo.Key);
        } while (keyInfo.Key != ConsoleKey.Escape);
        */
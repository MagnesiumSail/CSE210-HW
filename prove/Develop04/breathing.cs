public class Breathing : ActivityLogic
{
    public Breathing()
    {
        
    }

    public void breathe()
    {
        Console.Write("Breathe In...   ");
        for (int i = 3; i > 0; i--)
        {
            Thread.Sleep(1000);
            Console.Write($"\b{i}");
        }
        Thread.Sleep(1000);
        Console.Write("\b \nBreathe Out...  ");
        for (int i = 6; i > 0; i--)
        {
            Thread.Sleep(1000);
            Console.Write($"\b{i}");
        }
        Console.Write("\b \n");
    }

    
}
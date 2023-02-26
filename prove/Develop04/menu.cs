public class Menu
{
    public Menu()
    {

    }
    public void displayMenu()
    {
        Console.WriteLine("Menu Options:\n\t1. Start Breathing Activity\n\t2. Start Reflecting Activity\n\t3. Start Listing Activity\n\t4. Quit\nSelect a choice from the menu: ");
    }

    protected void Welcome(string activityName)
    {
        Console.WriteLine($"\nWelcome to the {activityName} Activity\n");
        if (activityName == "Breathing")
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.\n");
        else if (activityName == "Reflecting")
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        else if (activityName == "Listing")
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
        else
            Console.WriteLine("There was an error inputting the activity name type.\n");
    }
    protected int getTime()
    {
        Console.WriteLine("How long, in seconds, would you like your session to last? ");
        return int.Parse(Console.ReadLine());
        
    }
    public void spinner(int spins)
    {
        List<char> spinn = new List<char> { '|', '/', '-', '\\'};
        Console.Write(" ");
        for(int x = 0; x < spins; x++)
        {
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(70);
                Console.Write($"\b{spinn[i]}");
            }
        }
        Console.Write("\b \n");
    }
}
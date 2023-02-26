public class ActivityLogic : Menu
{
    public ActivityLogic()
    {

    }

    public void initializeActivity(string activityType)
    {
        Console.Clear();
        base.Welcome(activityType);
        int time = base.getTime();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        base.spinner(10);
        switch (activityType)
        {
            case "Breathing":
                BreathingLogic(time);
                break;
            case "Reflecting":
                reflectingLogic(time);
                break;
            case "Listing":
                listingLogic(time);
                break;
        }
        Console.WriteLine($"Well Done!\n\nYou have completed another {time} seconds of the {activityType} activity");
        base.spinner(20);
    }
    
    protected void BreathingLogic(int time)
    {
        Breathing Breathing1 = new Breathing();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(time);
        while (currentTime < futureTime)
        {
            Breathing1.breathe();
            currentTime = DateTime.Now;
        }
    }
    protected void reflectingLogic(int time)
    {
        Reflecting reflect1 = new Reflecting();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine(reflect1.randomPrompt());
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in:  ");
        for (int i = 6; i > 0; i--)
        {
            Console.Write($"\b{i}");
            Thread.Sleep(1000);
        }
        Console.Clear();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(time);
        while (currentTime < futureTime)
        {
            Console.Write(reflect1.returnReflect());
            base.spinner(30);
            currentTime = DateTime.Now;
        }
    }
    protected void listingLogic(int time)
    {
        Listing list1 = new Listing();
        Console.WriteLine(list1.randomListing());
        Console.Write("You may begin in:  ");
        for (int i = 6; i > 0; i--)
        {
            Console.Write($"\b{i}");
            Thread.Sleep(1000);
        }
        Console.Write("\b \n");
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(time);
        int count = 0;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            count++;
            Console.ReadLine();

            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {count} items!");
    }
}
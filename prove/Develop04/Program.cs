using System;
class Program
{
    static void Main(string[] args)
    {
        Menu menu1 = new Menu();
        Breathing breathing1 = new Breathing();
        ActivityLogic logic1 = new ActivityLogic();
        Reflecting reflect1 = new Reflecting();

        for (int selection = 0; selection != 4;)
        {
            menu1.displayMenu();
            selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    logic1.initializeActivity("Breathing");
                    break;
                case 2:
                    logic1.initializeActivity("Reflecting");
                    break;
                case 3:
                    logic1.initializeActivity("Listing");
                    break;      
            }
        }
    }
}
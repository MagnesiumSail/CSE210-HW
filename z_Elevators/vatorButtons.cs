public class vatorButton : Elevator
{

    int whichButton;
    public vatorButton()
    {
        
    }

    public void buttonPush()
    {
        Console.WriteLine("Which button do you push?");
        whichButton = int.Parse(Console.ReadLine());  
        if (whichButton < 0)
        {
            Console.WriteLine("You are poking a wall");
            return;
        }
        if (whichButton > 31)
        {
            Console.WriteLine("There's no button there");
            return;
        }
        building[whichButton - 1].getFloorNumber();

    }

    
}
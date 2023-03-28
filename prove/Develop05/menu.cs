public class Menu
{
    int _menuChoice = 0;
    public Menu()
    {
       
    }
    public void menuLogic(GoalManager goalmanager, GoalFileManager fileManager)
    {
        while(_menuChoice != 6)
        {
        DisplayMenu(goalmanager.getPoints());
        _menuChoice = int.Parse(Console.ReadLine());
        switch (_menuChoice) {
            case 1:
                goalsMenu(goalmanager);
                break;
            case 2:
                goalmanager.DisplayGoals();
                break;
            case 3:
                fileManager.SaveGoals(goalmanager._goals);
                break;
            case 4:
                goalmanager._goals = fileManager.LoadGoals();
                break;
            case 5:
                goalmanager.DisplayGoals();
                goalmanager.RecordEvent();
                break;
            case 6:
                break;
        }
        }
    }
    private void DisplayMenu(int points)
    {
        Console.WriteLine($"You have {points} points.\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.WriteLine("Select a choice from the menu:");
    }
    
private void goalsMenu(GoalManager goalmanager)
{
    Console.WriteLine("The types of goals are:");
    Console.WriteLine("\t1. Simple Goal");
    Console.WriteLine("\t2. Eternal Goal");
    Console.WriteLine("\t3. Checklist Goal");
    Console.WriteLine("Which type of goal would you like to create?: ");
    int goalType = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the name of the goal:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter a description for the goal:");
    string description = Console.ReadLine();

    Console.WriteLine("Enter the value of the goal:");
    int value = int.Parse(Console.ReadLine());

    switch (goalType) 
    {
        case 1:
            goalmanager.CreateGoal(name, description, value, goalType);
            break;
        case 2:
            goalmanager.CreateGoal(name, description, value, goalType);
            break;
        case 3:
            Console.WriteLine("Enter the target count of the goal:");
            int listCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the bonus points of the goal:");
            int bonusPoints = int.Parse(Console.ReadLine());

            goalmanager.CreateGoal(name, description, value, goalType, listCount, bonusPoints);
            break;
        default:
            Console.WriteLine("Invalid goal type");
            break;
    }
}

}

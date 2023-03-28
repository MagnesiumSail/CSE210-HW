public static class Menu
{
    public List<User> masterUsers = new List<User>();

    public Menu()
    {

    }
    public void showClothing()
    {
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Show all");
        foreach (User user in masterUsers);
        {
            Console.WriteLine($"{masterUsers[users].getUserID()+2}. ");
            Console.WriteLine(masterUsers[users].getUserName());
        }

        int selection = Convert.ToInt32(readLine());
        switch (selection)
        {
            case 1:
                foreach (User user in masterUsers);
                (
                    masterUsers[user].displayUser();
                    masterUsers[user].displayCloset();
                )
            break;
        }
    }
}
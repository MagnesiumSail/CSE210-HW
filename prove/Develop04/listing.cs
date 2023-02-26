public class Listing
{
    public string randomListing()
    {
        Random rnd = new Random();
        int trad = rnd.Next(1,6);
        switch (trad)
        {
            case 1:
                return "---Who are people that you appreciate?---";
            case 2:
                return "---What are personal strengths of yours?---";
            case 3:
                return "---Who are people that you have helped this week?---";
            case 4:
                return "---When have you felt the Holy Ghost this month?---";
            case 5:
                return "---Who are some of your personal heroes?---";
        }
        return "How the frick did you get this";
    }
}
public class RandoPrompt
{
    public string RandomPrompts(string bread)
    {
        Random rnd = new Random();
        int number  = rnd.Next(1, 6);
        Console.WriteLine(number);

        switch (number)
        {
            case 1:
                    bread = "What was your favorite thing you saw today?";
                    break;
            case 2:
                    bread = "What was the best conversation you had today?";
                    break;
            case 3:
                    bread = "What was one thing odd you noticed today?";
                    break;
            case 4:
                    bread = "What was the most productive thing you did today?";
                    break;
            case 5:
                    bread = "Where was your favorite place you went today?";
                    break;

        }
        return bread;
    }
}
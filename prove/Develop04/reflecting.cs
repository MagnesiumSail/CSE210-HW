public class Reflecting : ActivityLogic
{
    public Reflecting()
    {

    }

    public string randomPrompt()
    {
        Random rnd = new Random();
        int trad = rnd.Next(1,5);
        switch (trad)
        {
            case 1:
                return "---Think of a time when you stood up for someone else.---";
            case 2:
                return "---Think of a time when you did something really difficult.---";
            case 3:
                return "---Think of a time when you helped someone in need.---";
            case 4:
                return "---Think of a time when you did something truly selfless.---";
        }
        return "How the frick did you get this";
    }

    public string returnReflect()
    {
        Random rnd = new Random();
        int trad = rnd.Next(1,10);
        switch (trad)
        {
            case 1:
                return "> Why was this experience meaningful to you?";
            case 2:
                return "> Have you ever done anything like this before?";
            case 3:
                return "> How did you get started?";
            case 4:
                return "> How did you feel when it was complete?";
            case 5:
                return "> What made this time different than other times when you were not as successful?";
            case 6:
                return "> What is your favorite thing about this experience?";
            case 7:
                return "> What could you learn from this experience that applies to other situations?";
            case 8:
                return "> What did you learn about yourself through this experience?";
            case 9:
                return "> How can you keep this experience in mind in the future?";
        }
        return "How did you manage to get this to display";

    }

    
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage: ");
        int Grade = int.Parse(Console.ReadLine());
        bool PassFail = true;
        string Letter = "";
        if (Grade >= 90)
        {
            Letter = "A";
            if (Grade < 93)
                {
                    Letter += "-";
                }
        }
        else if (Grade >= 80)
        {
            Letter = "B";
            if (Grade < 83)
                {
                    Letter += "-";
                }
                else if (Grade >= 87)
                {
                    Letter += "+";
                }
        }
        else if (Grade >= 70)
        {
            Letter = "C";
            if (Grade < 73)
                {
                    Letter += "-";
                }
                else if (Grade >= 77)
                {
                    Letter += "+";
                }
        }
        else if (Grade >= 60)
        {
            Letter = "D";
            PassFail = false;
            if (Grade < 63)
                {
                    Letter += "-";
                }
                else if (Grade >= 67)
                {
                    Letter += "+";
                }
            
        }
        else
        {
            Letter = "F";
            PassFail = false;
        }
        Console.WriteLine($"You got a {Letter}");
        if (PassFail == true)
        {
            Console.WriteLine("Congratulations on passing!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass, but you'll do better next year!");
        }
    }
}
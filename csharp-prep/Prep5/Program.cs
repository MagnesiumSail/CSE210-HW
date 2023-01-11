using System;

class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int favNumber)
    {
        int output = favNumber * favNumber;
        return output;
    }
    static void DisplayResult(string name, int number )
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
    static void Main(string[] args)
    {
        DisplayMessage();

        string nameOut = PromptUserName();
        int favNumber = PromptUserNumber();
        int SquaredNumber = SquareNumber(favNumber);

        DisplayResult(nameOut, SquaredNumber);
    }
}
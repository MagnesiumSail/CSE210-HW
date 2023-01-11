using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int inputNumber = 99;
        double sum = 0;
        int entries = 0;
        int largest = 0;
        while (inputNumber != 0)
        {
            Console.Write("Enter number: ");
            inputNumber = int.Parse(Console.ReadLine());
            sum += inputNumber;
            if (inputNumber != 0)
                entries++;
            if (inputNumber > largest)
                largest = inputNumber;
        }
        double average = sum / entries;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {largest}");
    }
}
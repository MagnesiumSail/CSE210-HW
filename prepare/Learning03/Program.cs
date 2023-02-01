using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(5, 6);
        fraction1.display();
        fraction2.display();
        fraction3.display();
        fraction1.setBottom(9);
        fraction1.setTop(3);
        Console.WriteLine($"{fraction1.getTop()}/{fraction1.getBottom()}");
        Console.WriteLine(fraction1.getFractionString());
        Console.WriteLine(fraction1.getDecimalValue());
    }
}
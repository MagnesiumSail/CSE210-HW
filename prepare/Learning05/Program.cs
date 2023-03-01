using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("Purple", 3),
            new Rectangle("Yellow", 6, 2),
            new Circle("Green", 4)
        };

        foreach (var i in shapes)
        {
            Console.WriteLine(i.getColor());
            Console.WriteLine(i.GetArea());
        }



    }
}
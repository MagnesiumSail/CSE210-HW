class Program
{
    static void Main(string[] args)
    {
        Shape Square = new Shape(15);
        Shape Rectangle = new Shape(8, 50);
        Square.area();
        Rectangle.area();
    }
}

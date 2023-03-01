public class Shape
{
    private int _length = 0;
    private int _width = 0;
    
    public Shape(int side)
    {
        _length = side;
        _width = side;
    }
    public Shape(int length, int width)
    {
        _length = length;
        _width = width;
    }
    public void area()
    {
        Console.WriteLine(_length * _width);
    }
}
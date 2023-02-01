class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public void display()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }
    public void setTop(int topNumber)
    {
        _top = topNumber;
    }
    public int getTop()
    {
        return _top;
    }
    public void setBottom(int bottomNumber)
    {
        _bottom = bottomNumber;
    }
    public int getBottom()
    {
        return _bottom;
    }
    public string getFractionString()
    {
        return ($"{_top}/{_bottom}");
    }
    public double getDecimalValue()
    {
        return (double) _top / (double) _bottom;
    }




}
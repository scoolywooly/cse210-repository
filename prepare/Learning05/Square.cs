public class Square : Shape
{
    private double _side;
    public Square(string color, double side,string name) : base(color,name)
    {
        _color = color;
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}
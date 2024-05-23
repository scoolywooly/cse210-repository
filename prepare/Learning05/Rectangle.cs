public class Rectangle : Shape
{
    private double _height;
    private double _width;
    public Rectangle(string color, double width, double height, string name) : base(color,name)
    {
        _color = color;
        _width = width;
        _height = height;
        
    }

    public override double GetArea()
    {
        return _width * _height;
    }
}
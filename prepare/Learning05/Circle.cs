public class Circle : Shape{
    private double _radius;

    public Circle(string color, float radius,string name)  : base(color, name)
    {
        _color = color;
        _radius = radius;
    }

    public double GetRadius() {
        return _radius;
    }

    public void SetRadius(float number) {
        _radius = number;
    }

    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }
}
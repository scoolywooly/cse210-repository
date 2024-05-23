public class Shape {
    protected string _color;
    protected string _name;
    public Shape(string color, string name) {
        _color = color;
        _name = name;
    }

    public string GetColor() {
        return _color;
    }

    public void SetColor(string newColor) {
        _color = newColor;
    }
    public string GetName() {
        return _name;
    }
    public void SetName(string newName) {
        _name = newName;
    }

    public virtual double GetArea() {
        return 0.00d;
    }


}
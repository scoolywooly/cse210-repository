using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> listOfShapes = new List<Shape>();


        Square roadSign = new Square("Green",1.00,"Square");
        listOfShapes.Add(roadSign);

        Rectangle box = new Rectangle("Blue",2.33,4.00,"Rectangle");
        listOfShapes.Add(box);

        Circle ball = new Circle("Pink",3.14f,"Circle");
        listOfShapes.Add(ball);

        foreach (Shape thing in listOfShapes) {
            Console.WriteLine($"{thing.GetName()}:\n");
            Console.WriteLine(thing.GetArea());
            Console.WriteLine(thing.GetColor());
            Console.Write("\n");
        };


    }
}
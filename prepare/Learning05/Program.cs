using System;

class Program
{
    static void Main(string[] args)
    {
        var shapes = new List<Shape>();

        var square = new Square("blue", 5);
        var rectangle = new Rectangle("red", 5, 4);
        var circle = new Circle("green", 7);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (var s in shapes){
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}
abstract class Shape{
    protected string _color;
    public Shape(string color){
        _color = color;
    }

    public string GetColor(){
        return _color;
    }
    public void SetColor(string color){
        _color = color;
    }
    abstract public double GetArea();
}
class Circle: Shape{
    private double _radius;
    public Circle(string color, double radius) : base (color){
        _radius = radius;
    }
    public override double GetArea(){
        return Math.PI * _radius * _radius;
    }
}
class Square: Shape{
    private double _side;
    public Square(string color, double side) : base (color){
        _side = side;
    }
    public override double GetArea(){
        return _side*_side;
    }
}
class Rectangle: Shape{
    private double _length;
    private double _width;
    public Rectangle(string color, double length, double width) : base (color){
        _length = length;
        _width = width;
    }
    public override double GetArea(){
        return _length*_width;
    }
}
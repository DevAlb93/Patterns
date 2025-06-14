﻿interface IShape
{
    void Draw();
}

class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
    }
}


class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Square");
    }
}

public class ShapeMaker 
{
    private IShape circle;
    private IShape rectangle;
    private IShape square;

    public ShapeMaker()
    {
        circle = new Circle();
        rectangle = new Rectangle();
        square = new Square();
    }

    public void DrawCircle()
    {
        circle.Draw();
    }
    public void DrawRectangle()
    {
        rectangle.Draw();
    }
    public void DrawSquare()
    {
        square.Draw();
    }
}

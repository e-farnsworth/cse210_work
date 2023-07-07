using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Purple", 5);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Red", 2.6, 3.25);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Blue", 7.2);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.CalculateArea());
            Console.WriteLine("");
        }


    }
}
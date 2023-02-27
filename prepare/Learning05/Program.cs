using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapelist = new List<Shape>();

        Square square1 = new Square("Red", 5);
        shapelist.Add(square1);
        

        Rectangle r1 = new Rectangle("Blue", 5, 10);
        shapelist.Add(r1);

        Circle c1 = new Circle("Purple", 5);
        shapelist.Add(c1);

        foreach (var shape in shapelist)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Color: {color}, Area: {area}");
        }
    }
}
using System;
namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Square();
            shape.Name = "Square";
            shape.Color = "Blue";
            ((Square)shape).Length = 4;
            shape.CalculateArea();
            shape.DisplayArea();
            shape = new Circle();
            shape.Name = "Circle";
            shape.Color = "Red";
            ((Circle)shape).Radius = 4;
            shape.CalculateArea();
            shape.DisplayArea();

        }
    }
}

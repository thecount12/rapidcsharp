using System;

namespace shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Square();
            ((Square)shape).Length = 4; // length
            shape.Name = "Square"; // inherit public
            shape.Color = "blue"; // inherit public
            shape.CalculateArea(); // calculate
            shape.DisplayArea(); // display area

            shape = new Circle();
            shape.Name = "Circle";
            shape.Color = "Red";
            ((Circle)shape).Radius = 4;
            shape.CalculateArea();
            shape.DisplayArea();

        }
    }
}

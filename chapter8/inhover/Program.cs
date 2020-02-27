using System;

namespace shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Length = 4; // length
            square.Name = "Square"; // inherit public
            square.Color = "blue"; // inherit public
            square.CalculateArea(); // calculate
            square.DisplayArea(); // display area

            Circle circle = new Circle();
            circle.Name = "Circle";
            circle.Color = "Red";
            circle.Radius = 4;
            circle.CalculateArea();
            circle.DisplayArea();

        }
    }
}

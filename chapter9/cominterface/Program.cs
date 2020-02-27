using System;

namespace Cominterface
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape shape = new Square();
            shape.Name = "Square";
            ((IColor)shape).Color = "Blue";
            ((Square)shape).SideLength = 4;
            shape.CalculateArea();
            shape.DisplayShapeName();
            ((IColor)shape).DisplayColor();
            shape.DisplayArea();

            shape = new Circle();
            shape.Name = "Circle";
            ((Circle)shape).Radius = 3.5f;
            shape.CalculateArea();
            shape.DisplayShapeName();
            shape.DisplayArea();
        }
    }
}

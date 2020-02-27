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
            float area = square.CalculateArea(); // calculate

            // output
            Console.WriteLine(String.Format("Shape: {0}", square.Name));
            Console.WriteLine(String.Format("Color: {0}", square.Color));
            Console.WriteLine(String.Format("Side: {0}", square.Length));
            Console.WriteLine(String.Format("Area: {0}", area));


            Circle circle = new Circle();

            circle.Name = "Circle";
            circle.Color = "Red";
            circle.Radius = 4;
            float circle_area = circle.CalculateArea();

            Console.WriteLine(String.Format("Shape: {0}", circle.Name));
            Console.WriteLine(String.Format("Color: {0}", circle.Color));
            Console.WriteLine(String.Format("Radius: {0}", circle.Radius));
            Console.WriteLine(String.Format("Area: {0}", circle_area));

            float area2 = square.CalculateArea(8);
            Console.WriteLine(String.Format("New area {0}", area2));

        }
    }
}

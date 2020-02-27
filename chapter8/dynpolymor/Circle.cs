public class Circle : Shape
{
    public float Radius { get; set; }
    public Circle() { }
    public override void CalculateArea()
    {
        _Area = (float)System.Math.PI * Radius * Radius;
    }

    public override void DisplayArea()
    {
        System.Console.WriteLine(string.Format("Color of circle: {0}", Color));
        System.Console.WriteLine(string.Format("Area of circle: {0}", _Area));
    }
}
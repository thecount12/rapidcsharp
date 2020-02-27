// base class
public class Shape
{
    protected float _Area;
    public string Name { get; set; }
    public string Color { get; set; }

    // default constructor
    public Shape() { }

    public virtual void CalculateArea() { }

    public virtual void DisplayArea()
    {
        System.Console.WriteLine(string.Format("Shape: {0}", Name));
        System.Console.WriteLine(string.Format("Color: {0}", Color));
        System.Console.WriteLine(string.Format("Area: {0}", _Area));
    }
}
namespace Abstract
    // base class 
    public abstract class Shape
{
    protected float _Area;
    public string Name { get; set; }
    public string Color { get; set; }
    public Shape() { }
    public abstract void CalculateArea();
    public virtual void DisplayArea()
    {
        System.Console.WriteLine(string.Format("Shape: {0}", Name));
        System.Console.WriteLine(string.Format("Color: {0}", Color));
        System.Console.WriteLine(string.Format("Area: {0}", _Area));
    }
}
}

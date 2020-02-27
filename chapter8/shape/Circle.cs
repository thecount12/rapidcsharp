public class Circle: Shape
{
    public float Radius { get; set; }
    public Circle() {}
    public float CalculateArea()
    {
        return (float) System.Math.PI * Radius * Radius;
    }
}
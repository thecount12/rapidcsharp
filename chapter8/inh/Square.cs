// derived class
public class Square : Shape
{
    public int Length { get; set; }

    //default constructor
    public Square() {}

    public float CalculateArea()
    {
        return Length * Length;
    }

    public float CalculateArea(int Length)
    {
        this.Length = Length;
        return CalculateArea();
    }
}

// derived class
public class Square : Shape
{
    public int Length { get; set; }

    //default constructor
    public Square() { }

    public override void CalculateArea()
    {
        _Area = Length * Length;
    }
}

namespace Abstract
{
    public class Square : Shape
    {
        public float Length { get; set; }
        public Square() { }
        public override void CalculateArea()
        {
            _Area = Length * Length;
        }
    }
}
namespace Cominterface
{
    public class Circle : Shape
    {
        public float Radius { get; set; }
        public override void CalculateArea()
        {
            _Area = (float)System.Math.PI * Radius * Radius;
        }
        public override void DisplayArea()
        {
            System.Console.WriteLine(string.Format("Area of Circle : {0}", _Area));
        }
    }
}
namespace Cominterface
{
    public class Square : Shape, IColor
    {
        public float SideLength { get; set; }
        public Square() { }
        public override void CalculateArea()
        {
            _Area = SideLength * SideLength;
        }
        public string Color { get; set; }
        public void DisplayColor()
        {
            System.Console.WriteLine(string.Format("Color: {0}", Color));
        }
    }
}

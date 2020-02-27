namespace Cominterface
{
    public abstract class Shape
    {
        protected float _Area;
        public string Name { get; set; }
        public Shape() { }
        public abstract void CalculateArea();
        public virtual void DisplayShapeName()
        {
            System.Console.WriteLine(string.Format("Shape: {0}", Name));
        }
        public virtual void DisplayArea()
        {
            System.Console.WriteLine(string.Format("Area: {0}", _Area));
        }
    }
}

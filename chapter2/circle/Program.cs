using System;

namespace circle
{
    class Program
    {
        static void Main(string[] args)
        {
            const float PI = 3.14f;
            int radius;
            float area;
            Console.WriteLine("Enter radius for circle; ");
            radius = Convert.ToInt32(Console.ReadLine());
            area = PI * radius * radius;
            Console.WriteLine("Area of circle : " + area.ToString());
            Console.ReadLine();
        }
    }
}

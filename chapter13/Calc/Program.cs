using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new MyCalculator();

            int result = calculator.Add(2, 3);
            System.Console.WriteLine("Result: {0}", result);
            if (result != 5)
                throw new InvalidOperationException();
        }
    }
}

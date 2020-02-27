using System;

namespace handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 42;
            int num2 = 0;
            int result = 0;
            try
            {
               result = num1/num2; 
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Divide by zero, please correct math problem");
            }
            finally
            {
                Console.WriteLine(String.Format("Result: {0}", result));
            }
        }
    }
}

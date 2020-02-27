using System;

namespace defthrow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // System.Console.WriteLine("Add 2+3: {0}", Add(2,3));
        }
        private static int Add(int a, int b)
        {
            // some code
            int foo = a + b;
            throw new NotImplementedException();
        }
    }
}

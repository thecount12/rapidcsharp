using System;

namespace myspan
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5 };
			Span<int> span = ar.AsSpan();

			var dest = new Span<int>(new int[ar.Length]);

			var newAr = span.ToArray();

			span.Clear();

			Console.WriteLine("Array:");
			foreach (var i in ar)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("Span:");
			foreach (var i in span)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("New Array:");
			foreach (var i in newAr)
			{
				Console.WriteLine(i);
			}
        }
    }
}

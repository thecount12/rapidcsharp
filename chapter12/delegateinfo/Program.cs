using System;

namespace delegateinfo
{
    public class Program
    {
        static int number = 0;
        public delegate void ShowDelegate(int n);
        public static void Number(int p)
        {
            number+=p; 
            System.Console.WriteLine("Double Number: {0}", number);
        }
        public static void Money(int q)
        {
            number*=q;
            System.Console.WriteLine("More Money: {0:C}", number);
        }
        public static int returnNum()
        {
            return number;
        }
        public static void Main()
        {
            ShowDelegate display = Number;
            // ShowDelegate display = new ShowDelegate(Number);
            display(42);
            display(100);
            display.Invoke(50);
            System.Console.WriteLine("Delgate object: {0}", returnNum());

            display = Money;
            display(42);
            display(200);
            System.Console.WriteLine("Delegate object: {0}", returnNum()/42);
        }
        
    }
}

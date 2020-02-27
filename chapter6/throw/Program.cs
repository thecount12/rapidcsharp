using System;

namespace throw_error
{

    public class MyException:Exception
    {
        public MyException (String message) : base (message) {}
        public MyException (String message, Exception inner) :
        base(message,inner) {}
    }

    public class Multi
    {
        public int Multiply(int x)
        {
           bool Valid;
           // write custom logic to validate x
           if(x != 0)
           {
               Valid = true;
           }
            else
            {
                Valid = false;
            }

           if(!Valid)
           {
               throw new MyException("Invalid number.");
           }
           // write code to perform the calculation
           return x * x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Multi calculate = new Multi();
            try
            {
                int result = calculate.Multiply(2);
                Console.WriteLine("Result:  " + result);
            }
            catch(MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

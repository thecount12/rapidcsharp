using System;

namespace userthrow
{

    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, System.Exception inner) : base(message, inner) { }
        protected MyException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    public class NewException: [System.Serializable]
    public class MyException : System.Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, System.Exception inner) : base(message, inner) { }
        protected MyException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    public class Multi
    {
        public int Multiply(int x)
        {
            bool Valid;
            // custom logic to validate x
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
                throw new MyException("Invalid value.");
            }
            // code to perform calculation
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
                int result = calculate.Multiply(1);
                Console.WriteLine(String.Format("Result: {0}", result));
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            
        }
    }
}

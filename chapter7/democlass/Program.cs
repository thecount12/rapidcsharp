using System;

namespace DemoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person william = new Person(); // create obj
            william.Id = 42;
            william.Name = "William";
            william.Display(); // display attribute

            Person mckinzie = new Person("Mckinzie"); // create obj
            mckinzie.Id = 43;
            mckinzie.DisplayName(); //display attribute
        }
    }
}

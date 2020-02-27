using System;

namespace employeeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            employeeDemo employeeA = new employeeDemo();
            employeeA.FirstName = "William";
            employeeA.LastName = "Gunnells";
            employeeA.Age = 42;
            employeeA.BirthDate = "May 18 1976";
            employeeA.Id = 1;

            employeeDemo employeeB = new employeeDemo();
            employeeB.FirstName = "McKinzie";
            employeeB.LastName = "Gunnells";
            employeeB.Age = 17;
            employeeB.BirthDate = "May 18 2001";
            employeeB.Id = 2;
            
            Console.WriteLine("First Name {0}", employeeA.FirstName );
            Console.WriteLine("Last Name {0}", employeeA.LastName );
            Console.WriteLine("Age {0}", employeeA.Age );
            Console.WriteLine("Birth date {0}", employeeA.BirthDate );
            Console.WriteLine("id {0}", employeeA.Id );

            Console.WriteLine("First Name {0}", employeeB.FirstName );
            Console.WriteLine("Last Name {0}", employeeB.LastName );
            Console.WriteLine("Age {0}", employeeB.Age );
            Console.WriteLine("Birth date {0}", employeeB.BirthDate );
            Console.WriteLine("id {0}", employeeB.Id );

        }
    }
}

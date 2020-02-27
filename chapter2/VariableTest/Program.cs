using System;
using static System.Console;

namespace VariableTest
{
    class Employee
    {
        static void Main(string[] args)
        {
            string fname, lname; 
            int age; 
            WriteLine("FName "); 
            fname =Convert.ToString(ReadLine()); 
            WriteLine("LName: "); 
            lname =Convert.ToString(ReadLine()); 
            WriteLine("Enter age: "); 
            age = Convert.ToInt32(ReadLine()); 
            WriteLine("Name: " + fname + " " + lname); 
            WriteLine("Your age is " + age); 
            ReadLine(); 

        }
    }
}

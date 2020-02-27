using System;

namespace over
{

    class EnrollmentBase
    { 
        public virtual void Student() 
        { 
            Console.WriteLine("science"); 
        } 
        public virtual void Resources() 
        { 
            Console.WriteLine("books"); 
        } 
    } 
    class StudentDerived : EnrollmentBase
    { 
        public override void Student() 
        { 
            // derived
            Console.WriteLine("Schedules - Different methods"); 
        } 
        public new void Resources() 
        { 
            // derived
            Console.WriteLine("Resources - Different methods"); 
        } 
    } 
    class Program
    {
        static void Main(string[] args)
        {
            EnrollmentBase bc = new EnrollmentBase();
            StudentDerived dc = new StudentDerived();
            EnrollmentBase both = new StudentDerived();

            bc.Student();
            bc.Resources();
            Console.WriteLine("------");
            dc.Student();
            dc.Resources();
            Console.WriteLine("------");
            both.Student();
            both.Resources();
        }
    }
}

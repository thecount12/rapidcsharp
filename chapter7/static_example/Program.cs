using System;

namespace static_example
{
    class Student
    {
        static int studentCount = 0;
        int studentNumber;
        string studentName;

        public Student(int number, string name)
        {
            studentNumber = number;
            studentName = name;
            studentCount++;
        }

        public static int Count
        {
            get { return studentCount;}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student studentA = new Student(42, "William Gunnells");
            Student studentB = new Student(43, "Mckinzie Gunnells");
            Console.WriteLine("Total Student objects = {0}", Student.Count);
        }
    }
}

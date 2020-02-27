using System;

namespace decision
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, result;
            int age;
            Console.WriteLine("Enter name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Name is: " + name);
            Console.WriteLine("Your age is: " + age);
            if (age <= 14)
            {
                Console.WriteLine("Too Younge to drive a car");
            } 
            else if (age <= 17)
            {
                Console.WriteLine("You can drive but not vote");
            } else
            {
                Console.WriteLine("Old enough to do both");
            }
            switch (age)
            {
                case 15:
                    result = "Needs drivers Permit";
                    break;
                case 18:
                    result = "is an adult";
                    break;
                case 21:
                    result =  "can drink alcohol";
                    break;
                default:
                    result = "is great";
                    break;
            }
            Console.WriteLine(String.Format("{0}: {1}", name, result));
        }
    }
}

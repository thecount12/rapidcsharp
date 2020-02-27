using System;

namespace DemoClass
{
    public class Person
    {
        // private fields
        private int _id;
        private string _name;

        // default constructor
        public Person()
        {
        }
        // parameterized constructor
        public Person(string name)
        {
            _name = name;
        }

        // properties
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        // methods
        public void DisplayName()
        {
            System.Console.WriteLine(string.Format("Name: {0}", _name));
        }
        public void Display()
        {
            System.Console.WriteLine(string.Format("Id: {0}", _id));
            System.Console.WriteLine(string.Format("Name: {0}", _name));
        }
    }
}
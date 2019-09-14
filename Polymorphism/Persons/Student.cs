using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Student : Person
    {
        private double _gpa;
        

        public Student(string firstName, string lastName, string address, int id, double gpa) : base(firstName,
            lastName, address, id)
        {
            _gpa = gpa;

        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("GPA: " + _gpa);
        }

    }
}

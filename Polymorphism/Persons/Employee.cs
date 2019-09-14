using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Employee : Person
    {
        private string _jobTitle;

        public Employee(string firstName, string lastName, string address, int id, string jobTitle) : base(firstName, lastName, address, id)
        {
            _jobTitle = jobTitle;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Job title: " + _jobTitle);
        }
    }
}

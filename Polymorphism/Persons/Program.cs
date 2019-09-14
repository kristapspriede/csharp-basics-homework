using System;
using System.Security.Cryptography.X509Certificates;

namespace Persons
{
    public class Person
    {

        string _firstName;
        string _lastName;
        string _address;
        int _id;

        public Person(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + _firstName);
            Console.WriteLine("Last name: " + _lastName);
            Console.WriteLine("Address: " + _address);
            Console.WriteLine("ID: " + _id);

        }
        static void Main(string[] args)
        {
            /*
             * - Create an instant of class Student and an instant of class Employee with proper values for the attributes.
             * - Display the content of each class using Display() method.
             */
             Student student1 = new Student("Kristaps", "Priede", "Riga", 81, 8.5);
             Person person1 = new Person("Jānis", "Rainis", "Jūrmala", 79);
             Employee employee = new Employee("Ilmārs", "Dzenis", "Ventspils", 78, "musician");

             student1.Display();
             Console.WriteLine();
             person1.Display();
             Console.WriteLine();
             employee.Display();
             Console.ReadKey();


        }
    }
}
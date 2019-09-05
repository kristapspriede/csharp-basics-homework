using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PhoneBook
{
    class Program
    {
        private static void Main(string[] args)
        {

            SortedDictionary<string, int> phoneDirectory = new SortedDictionary<string, int>();

            phoneDirectory.Add("Kristaps", 27010890);
            phoneDirectory.Add("Jānis", 26781345);
            phoneDirectory.Add("Ilze", 2728989);
            phoneDirectory.Add("Ivars", 21234545);
            do
            {
                Console.WriteLine("**************************");
                Console.WriteLine("        Phone Book       ");
                Console.WriteLine("**************************");
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("[1] Add new contact");
                Console.WriteLine("[2] Search by name");
                Console.WriteLine("[3] Search by number");
                Console.WriteLine("[4] Exit");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter name: ");
                        string nameInput = Console.ReadLine();
                        Console.WriteLine("Enter number: ");
                        int numberInput = Convert.ToInt32(Console.ReadLine());
                        phoneDirectory.Add(nameInput, numberInput);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Enter name: ");
                        string nameSearch = Console.ReadLine();
                        GetNumber(nameSearch);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("Enter number: ");
                        int numberSearch = Convert.ToInt32(Console.ReadLine());
                        GetName(numberSearch);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                }
            } while (true);
            
            void GetNumber(string name)
            {
                foreach (KeyValuePair<string, int> item in phoneDirectory)
                {
                    if (name == item.Key)
                        Console.WriteLine("Number: " + item.Value);
                }
            }

            void GetName(int number)
            {
                foreach (KeyValuePair<string, int> item in phoneDirectory)
                {
                    if (number == item.Value)
                        Console.WriteLine("Name: " + item.Key);
                }
            }
            
            
            
        }
    }
}
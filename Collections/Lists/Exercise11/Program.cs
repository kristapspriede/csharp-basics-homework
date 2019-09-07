using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        private static void Main(string[] args)
        {
            //TODO: Create an List with string elements
            var animals = new List<string>
            {
                "Lion",
                "Dog",
                "Horse",
                "Cat",
                "Ant"
            };
            //TODO: Add 10 values to list

            animals.Add("Elephant");
            animals.Add("Fox");
            animals.Add("Wolf");
            animals.Add("Eagle");
            animals.Add("Snake");
            animals.Add("Shark");
            animals.Add("Zebra");
            animals.Add("Deer");
            animals.Add("Mouse");
            animals.Add("Stork");

            Console.WriteLine(string.Join(",", animals));


            //TODO: Add new value at 5th position

            animals.Insert(4, "Cow");
            Console.WriteLine(string.Join(",", animals)); 

            animals[animals.Count - 1] = "Turtle";
            Console.WriteLine(string.Join(",", animals));
            //TODO: Sort your list in alphabetical order
            animals.Sort();
            Console.WriteLine(string.Join(",", animals));
            //TODO: Check if your list contains "Foobar" element

            if (animals.Contains("Foobar"))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");

            }

            //TODO: Print each element of list using loop

            for (int i = 0; i < animals.Count; i++)
            {
               Console.Write(animals[i] + ", "); 
            }

            Console.ReadKey();
        }
    }
}
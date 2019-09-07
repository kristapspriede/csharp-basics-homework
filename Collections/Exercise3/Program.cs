using System;
using System.Collections.Generic;

namespace CollectionExercise3
{
    class Program
    {
        private static void Main(string[] args)
        {
            var mySet = new HashSet<string>();

            //TODO: add 5 values to Set.
            mySet.Add("Red");
            mySet.Add("Black");
            mySet.Add("Yellow");
            //..
            mySet.Add("White");
            mySet.Add("Brown");




            //TODO: iterate through all elements in set
            Console.WriteLine("Should have 5 elements: ");
            Console.WriteLine(string.Join(",", mySet)); //Pay attention on order!





            //TODO: remove all values from set

            mySet.Clear();
            
            Console.WriteLine("Is mySet empty: ");
            Console.WriteLine(mySet.Count == 0);

            //TODO: check if it is possible to add duplicated values

            mySet.Add("Green");
            mySet.Add("Orange");
            mySet.Add("Green");
            mySet.Add("Purple");

            mySet.Add("Green");

            Console.WriteLine(string.Join(",", mySet));
        }
    }
}
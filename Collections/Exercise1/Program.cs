using System;
using System.Collections.Generic;

namespace CollectionExercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = {"Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla"};

            //todo - replace array with an List and print out the results
            List<string> intList = new List<string>() { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            foreach (var i in intList)
                Console.Write(i);
            Console.WriteLine();

            //todo - replace array with a HashSet and print out the results
            HashSet<string> hashList = new HashSet<string>();
            for (int i = 0; i < array.Length; i++)
            {
                hashList.Add(array[i]);
            }
            foreach (string i in hashList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            //todo - replace array with a Dictionary (use brand as key and origination as value) and print out the results

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Audi", "Germany");
            dict.Add("BMW", "Germany");
            dict.Add("Honda", "Japan");
            dict.Add("Mercedes", "Germany");
            dict.Add("VolksWagen", "Germany");
            dict.Add("Tesla", "USA");

            foreach (KeyValuePair<string, string> car in dict)
            {
                Console.WriteLine("{0} and {1}",
                          car.Key, car.Value);
            }
            Console.WriteLine();


            Console.ReadKey();
        }
        
        
    }
}
using System;
using System.Collections.Generic;
using System.IO;


namespace FlightPlanner
{
    class Program
    {
        private const string Path = "C:/Users/krist/csharp-basics-homework/Collections/FlightPlanner/flights.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path);
            string[] arrows = new string[] { " -> ", "\r\n" };
            var text = readText.Split(arrows, StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> flightList = new HashSet<string>();

            foreach (var s in text)
            {
                flightList.Add(s);
            }

            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");
            var input = Console.ReadLine();
            

            switch (input)
            {
                case 1:
                    foreach (var i in flightList)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case "#":
                    Console.WriteLine("Two");
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }

            foreach (var i in flightList)
            {
                Console.WriteLine(i);
            }

            //foreach (var i in flightList)
            //{
            //    Console.WriteLine(i);
            //}


        }
    }
}
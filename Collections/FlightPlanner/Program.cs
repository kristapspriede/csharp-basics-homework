using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


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

            List<string> airports = new List<string>();

            foreach (var s in text)
            {
                airports.Add(s);
            }
            
            List<string> startingAirports = new List<string>();
            List<string> destinationAirports = new List<string>();
            for (int i = 0; i < airports.Count; i += 2)
            {
                string startKey = airports[i];
                string destinationKey = airports[i + 1];
                startingAirports.Add(startKey);
                destinationAirports.Add(destinationKey);
            }


            HashSet<string> uniqueAirports = new HashSet<string>();
            foreach (var s in text)
            {
                uniqueAirports.Add(s);
            }
            List<string> airportList = uniqueAirports.ToList();
            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");
            var input = Console.ReadLine();

            int nr = 1;

            switch (input)
            {
                case "1":
                    Console.WriteLine("Choose your starting point: ");
                    foreach (var item in airportList)
                    {
                        Console.WriteLine("[" + nr + "]" + " " + item);
                        nr++;
                    }

                    var input1 = Int32.Parse(Console.ReadLine()); 
                    for (int i = 0; i < airportList.Count; i++)
                    {
                        if (input1 == i + 1)
                        {
                            Console.WriteLine(airportList[i]);
                            for (var j = 0; j < startingAirports.Count; j++)
                            {
                                if (airportList[i] == startingAirports[i])
                                {
                                    Console.WriteLine(startingAirports[i] + " => " + destinationAirports[i]);
                                }
                            }
                        }

                        


                    }
                    

                    break;
                case "#":
                    Console.WriteLine("Thank You!");
                    break;
            }




            Console.ReadKey();
            
        }
    }
}
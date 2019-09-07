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
            string firstCity = "";
            string route = "";
            List<string> airports = new List<string>();
            foreach (var s in text)
            {
                airports.Add(s);
            }
            List<string> temporaryList = new List<string>();
            List<string> startingAirports = new List<string>();
            List<string> destinationAirports = new List<string>();
            for (int i = 0; i < airports.Count; i += 2)
            {
                string startKey = airports[i];
                string destinationKey = airports[i + 1];
                startingAirports.Add(startKey);
                destinationAirports.Add(destinationKey);
            }


            HashSet<string> uniqueAirports = new HashSet<string>(); //Get unique airports
            foreach (var s in text)
            {
                uniqueAirports.Add(s);
            }
            List<string> airportList = uniqueAirports.ToList(); //Add unique airports to list

            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");
            var input = Console.ReadLine();



            switch (input)
            {
                case "1":
                    Console.WriteLine("Choose starting city: ");
                    for (int i = 0; i < airportList.Count; i++)
                    {
                        Console.WriteLine("[" + i + "] " + airportList[i]);
                    }


                    var input1 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < airportList.Count; i++)
                    {
                        if (input1 == i)
                        {
                            firstCity = airportList[i];
                            route += airportList[i] + " => ";
                            break;
                        }
                    }
                    Console.WriteLine("Choose next city:");
                    for (int i = 0; i < startingAirports.Count; i++)
                    {
                        if (startingAirports[i] == firstCity)
                        {
                            temporaryList.Add(destinationAirports[i]);
                        }
                    }
                    for (int i = 0; i < temporaryList.Count; i++)
                    {
                        Console.WriteLine("[" + i + "] " + temporaryList[i]);

                    }

                    Console.WriteLine();
                    string city;

                    while (true)
                    {
                        city = temporaryList[Convert.ToInt32(Console.ReadLine())];
                        temporaryList.Clear();
                        if (city == firstCity)
                        {
                            route += firstCity;
                            break;
                        }
                        route += city + " => ";
                        for (int i = 0; i < startingAirports.Count; i++)
                        {
                            if (city == startingAirports[i])
                            {

                                temporaryList.Add(destinationAirports[i]);
                            }
                        }

                        Console.WriteLine("Choose next city:");
                        for (int i = 0; i < temporaryList.Count; i++)
                        {
                            Console.WriteLine("[" + i + "] " + temporaryList[i]);
                        }
                    }
                    break;
                case "#":
                    Console.WriteLine("Thank You!");
                    break;
            }
            Console.WriteLine(route);
            Console.WriteLine("Thank You");
            Console.ReadKey();
        }
    }
}
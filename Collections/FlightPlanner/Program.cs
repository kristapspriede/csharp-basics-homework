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
            //List<Tuple<string, string>> flightList = new List<Tuple<string, string>>();
            Dictionary<string, string> list = new Dictionary<string, string>();
            for (int i = 0; i < airports.Count; i += 2)
            {
                string startKey = airports[i];
                string destinationKey = airports[i + 1];
                list.Add(startKey, destinationKey);
            }


            //int nr = 1;
            //foreach (Tuple<string, string> tuple in flightList)
            //{
            //    Console.WriteLine(nr + ". " + tuple.Item1);
            //    nr++;
            //}

            //for (int k = 0; k < startingAirports.Count; k++)
            //{
            //    Console.WriteLine(startingAirports[k] + " => " + destinationAirports[k]);
            //}


            HashSet<string> startingAirports = new HashSet<string>();
            foreach (var s in text)
            {
                startingAirports.Add(s);
            }
            int nr = 1;
            List<Tuple<int, string>> airportList = new List<Tuple<int, string>>();
            foreach (var s in startingAirports)
            {
                airportList.Add(Tuple.Create(nr, s));
                nr++;
            }


            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");
            var input = Console.ReadLine();


            switch (input)
            {

                case "1":
                    Console.WriteLine("Choose your starting point: ");
                    foreach (Tuple<int, string> tuple in airportList)
                    {
                        Console.WriteLine(tuple.Item1 + ". " + tuple.Item2);

                    }
                    break;
                case "#":
                    Console.WriteLine("Thank You!");
                    break;

            }

            //var input1 = Convert.ToInt32(Console.ReadLine());
            //checkAirport(input1);

            //void checkAirport(int input)
            //{
            //    foreach (Tuple<int, string> tuple in airportList)
            //    {

            //    }
            //}
            //foreach (Tuple<int, string> tuple in airportList)
            //{
            //    if (input1 == tuple.Item1)
            //    {
            //        Console.WriteLine("Choose next stop: ");
            //        foreach (Tuple<string, string> tuple2 in flightList)
            //        {

            //            if (input == tuple2.Item1)
            //            {
            //                Console.WriteLine(tuple2.Item2);
            //            }
            //            else if (tuple.Item2 == tuple2.Item2)
            //            {
            //                Console.WriteLine("You reached starting point!");
            //                Console.WriteLine(tuple.Item2 + " => " + tuple2.Item1 + " => " + tuple2.Item2);
            //            }
            //        }
            //    }

            //    //Console.WriteLine(tuple.Item1 + ". " + tuple.Item2);

            //}






            Console.ReadKey();
            //foreach (var i in flightList)
            //{
            //    Console.WriteLine(i);
            //}
            //Dictionary<int, Dictionary<int, string>> flightListDictionary = new Dictionary<int, Dictionary<int, string>>();

            //List<string> flightListDictionary = new List<string>();

            ////flightList.Distinct();
            //int i = 1;
            //foreach (var item in startingAirports)
            //{
            //    flightListDictionary.Add(item);
            //    Dictionary<int, string> destinationAirport = new Dictionary<int, string>();
            //    i++;
            //}




        }
    }
}
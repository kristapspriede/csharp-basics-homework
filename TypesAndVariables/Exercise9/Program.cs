using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInputDistance;
            int userInputHours;
            int userInputMinutes;
            int userInputSeconds;
            int timeInSeconds;
            Console.WriteLine("Enter distance in meters:");
            userInputDistance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter hours:");
            userInputHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes:");
            userInputMinutes = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter seconds:");
            userInputSeconds = int.Parse(Console.ReadLine());

            timeInSeconds = (userInputHours * 3600 + userInputMinutes * 60 + userInputSeconds);

            Console.WriteLine("Your speed in meters/second is " + (double)userInputDistance / timeInSeconds);
            Console.WriteLine("Your speed in km/h is " + 3.6 * ((double)userInputDistance / timeInSeconds));
            Console.WriteLine("Your speed in miles/h is " + (3.6/(double)1.609) * ((double)userInputDistance / timeInSeconds));

            Console.ReadKey();
        }
    }
}

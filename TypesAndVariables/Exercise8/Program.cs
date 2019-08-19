using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 100;
            
            double minutesInDay = 1440;
            double minutesInYear = 525600;

            Console.WriteLine(minutes + " is " + (minutes/minutesInDay) + " days and " +
                              (minutes / minutesInYear) + " year.");
            Console.ReadKey();

        }
    }
}

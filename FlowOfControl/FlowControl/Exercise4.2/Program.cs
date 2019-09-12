using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day number:");
            var dayNumber = Convert.ToInt32(Console.ReadLine());

            if (dayNumber == 0)
            {
                Console.WriteLine("Monday");
                Console.ReadKey();
            } else if (dayNumber == 1)
            {
                Console.WriteLine("Tuesday");
                Console.ReadKey();
            }
            else if (dayNumber == 2)
            {
                Console.WriteLine("Wednesday");
                Console.ReadKey();
            }
            else if (dayNumber == 3)
            {
                Console.WriteLine("Thursday");
                Console.ReadKey();
            }
            else if (dayNumber == 4)
            {
                Console.WriteLine("Friday");
                Console.ReadKey();
            }
            else if (dayNumber == 5)
            {
                Console.WriteLine("Saturday");
                Console.ReadKey();
            }
            else if (dayNumber == 6)
            {
                Console.WriteLine("Sunday");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Not a valid day");
                Console.ReadKey();
            }
        }
    }
}

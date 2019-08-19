using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day number:");
            var dayNumber = Convert.ToInt32(Console.ReadLine());

            switch (dayNumber)
            {
                case 0:
                    Console.WriteLine("Monday");
                    Console.ReadKey();
                    break;
                case 1:
                    Console.WriteLine("Tuesday");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Wednesday");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Thursday");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Friday");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Saturday");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Sunday");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Not a valid day");
                    Console.ReadKey();
                    break;
            }
        }
    }
}

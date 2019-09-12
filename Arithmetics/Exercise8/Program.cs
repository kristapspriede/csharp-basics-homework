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
            
            Console.WriteLine(Wage(7.50, 35));
            Console.ReadKey();
            static string Wage(double basePay, int hours)
            {
                if (hours > 60)
                {
                    return "Error";
                }   else if (hours > 40)
                {
                    return "$" + (40 * basePay + (hours - 40) * basePay * 1.5);
                }
                else
                {
                    return "$" + basePay*hours;
                }
            }
        }
    }
}

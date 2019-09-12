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
            Console.WriteLine(BMI(250, 80, "imperial"));
            Console.ReadKey();
        }

        static string BMI(double weight, double height, string units )
        {
            if (units == "metric")
            {
                weight = weight * 2.20;
                height = height * 39.37;
            }
            if (((weight * 703) / (height * height))< 18.5)
            {
                return "You are underweight!" + ((weight * 703) / (height * height));
            } else if (((weight * 703) / (height * height)) > 25)
            {
                return "You are overweight!" + ((weight * 703) / (height * height));
            }
            else
            {
                return "You are in optimal weight!" + ((weight * 703) / (height * height));
            }
        }
    }
}

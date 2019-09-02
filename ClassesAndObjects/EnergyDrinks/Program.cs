using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            //fixme
            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine("Approximately " + (NumberedSurveyed * PurchasedEnergyDrinks) + " bought at least one energy drink");
            Console.WriteLine((NumberedSurveyed * PurchasedEnergyDrinks * PreferCitrusDrinks) + " of those " + NumberedSurveyed + " prefer citrus flavored energy drinks.");
            Console.ReadKey();
        }

        double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return NumberedSurveyed * PurchasedEnergyDrinks;
        }

        double CalculatePreferCitrus(int numberSurveyed)
        {
            return NumberedSurveyed * PurchasedEnergyDrinks * PreferCitrusDrinks;
        }
        
    }
}

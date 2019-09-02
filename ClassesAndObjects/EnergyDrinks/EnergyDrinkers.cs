using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class EnergyDrinkers
    {
        private  int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        public EnergyDrinkers(int numberSurveyed)
        {
            NumberedSurveyed = numberSurveyed;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;

            Car car = new Car(0);
            for (int i = 0; i < 1; i++)
            {
                Console.Write("Enter distance traveled: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters consumed: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car.FillUp(startKilometers, liters);
            }
            Console.WriteLine("Kilometers driven per liter " + string.Format("{0:F2}", car.calculateConsumption()));
            Console.WriteLine("Liters per 100 kilometers " + string.Format("{0:F2}", car.consumptionPer100Kilometers()) + " gasHog: " + car.GasHog() + "; Economy car: " + car.EconomyCar());
            Console.ReadKey();
        }
    }
}

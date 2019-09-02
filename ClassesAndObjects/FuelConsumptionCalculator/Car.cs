using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Car
    {

        private double _currentMileage; // Starting odometer reading
        
        private double _liters; // Liters of gas used between the readings
        

        public Car(double startOdo)
        {
            _currentMileage = startOdo;
            

        }

        public double calculateConsumption()
        {
            return _currentMileage / _liters;
        }

        public double consumptionPer100Kilometers()
        {
            return 100 / calculateConsumption();
        }

        public bool GasHog()
        {
            if (consumptionPer100Kilometers() > 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EconomyCar()
        {
            if (consumptionPer100Kilometers() < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void FillUp(int mileage, double liters)
        {
            _liters += liters;
            _currentMileage += mileage;
        }
    }
}

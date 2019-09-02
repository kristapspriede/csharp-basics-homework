using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Odometer
    {
        private int _mileage;
        private const int _maxMileage = 999999;
        private const int _minMileage = 0;
        private FuelGauge _fuelGauge;


        public Odometer()
        {
            _fuelGauge = new FuelGauge();
        }
        public int Report()
        {
            return _mileage;
        }

        public void Increment()
        {

            if (_mileage < _maxMileage)
            {
                _mileage++;
            }
            //if (_mileage % 10 == 0)
            //{
            //    _fuelGauge.DecreasedLevel();
            //}

            //if (_fuelGauge.ReportLevel() > 0)
            //{


            //    if (_mileage < _maxMileage)
            //        _mileage++;
            //    if (_mileage % 10 == 0)
            //    {
            //        _fuelGauge.DecreasedLevel();
            //    }
            //    else
            //    {
            //        _mileage = 0;

            //    }
            //    if (_mileage % 10 == 0)
            //    {
            //        _fuelGauge.DecreasedLevel();
            //    }

        }
    }
}

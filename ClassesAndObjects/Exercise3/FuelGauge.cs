using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise3
{
    public class FuelGauge
    {
        public int _fuelLevel;
        private const int _maxLevel = 70;
        private const int _minLevel = 0;

        public int ReportLevel()
        {
            return _fuelLevel;
        }

        public void Fill()
        {
            if (_fuelLevel < _maxLevel)
            {
                _fuelLevel++;
            }
        }

        public void DecreasedLevel()
        {
            if (_fuelLevel > _minLevel)
            {
                _fuelLevel--;
            }
            //else if (_fuelLevel <= 0)
            //{
            //    Fill();
            //}
            
        }
        
    }
}

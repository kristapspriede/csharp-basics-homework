using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    class Commission : Hourly
    {
        private double _totalSales;
        private double _commissionRate;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRate = commissionRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales = totalSales;
        }
        public override double Pay()
        {
            return base.Pay() + (_commissionRate * _totalSales);
        }

       
        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales: " + _totalSales;
            return result;
        }
    }
}

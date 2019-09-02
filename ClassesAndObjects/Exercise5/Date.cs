using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Date
    {
        private int _month;
        private int _day;
        private int _year;


        public Date(int month, int day, int year)
        {
            _month = month;
            _day = day;
            _year = year;
        }
        public string DisplayDate()
        {
            return _month + "/" + _day + "/" + _year ;
        }

    }
}

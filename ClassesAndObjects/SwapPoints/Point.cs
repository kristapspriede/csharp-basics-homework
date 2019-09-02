using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapPoints
{
    class Point
    {
        
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int x
        {
            get { return _x; }
            set { _x = value; }
        }

        public int y
        {
            get { return _y; }
            set { _y = value; }
        } 

        public void SwapPoints(ref Point point1, ref Point point2)
        {
            var tempX = point1;

            point1 = point2;
            point2 = tempX;

            //int tempswap = x;
            //x = y;
            //y = tempswap;


        }
    }
}

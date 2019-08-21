using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static decimal areaOfCircle(decimal radius)
        {
            
            return (decimal)Math.PI * (radius * radius);
        }

        public static decimal areaOfRectangle(decimal length, decimal width)
        {
            return length * width;
        }

        public static double areaOfTriangle(decimal ground, decimal height)
        {
           return (double)ground * (double)height * 0.5;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapPoints
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);

            p1.SwapPoints(ref p1,ref p2);
            
            Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
            Console.WriteLine("(" + p2.x + ", " + p2.y + ")");
            Console.ReadKey();
        }
    }
}

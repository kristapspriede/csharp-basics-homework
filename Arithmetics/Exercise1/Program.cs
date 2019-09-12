using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(CheckNumbers(4, 5));
            Console.ReadKey();
        }
        static bool CheckNumbers(int a, int b)
        {
            return a == 15 || b == 15 || a + b == 15 || a - b == 15;
         }
    }
}

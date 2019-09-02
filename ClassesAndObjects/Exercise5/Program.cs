using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var date1 = new Date(12,24,1988);
            Console.WriteLine(date1.DisplayDate());

            Console.ReadKey();
        }
    }
}

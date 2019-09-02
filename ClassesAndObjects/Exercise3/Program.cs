using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("new odometer");
            var fuelGauge = new FuelGauge();
            for (int i = 0; i < 50; i++)
            {
                fuelGauge.Fill();
            }

            Console.WriteLine($"fuel level:{fuelGauge.ReportLevel()}");
            var odometer = new Odometer();
            Console.WriteLine("running...");

            for (int i = 0; i < 80; i++)
            {
                
                odometer.Increment();
                Console.WriteLine($"odometer report:{ odometer.Report()}");

                if (i % 10 == 0)
                {
                    fuelGauge.DecreasedLevel();
                }

                if (fuelGauge._fuelLevel == 0)
                {
                    for (int j = 0; j < 50; j++)
                    {
                        fuelGauge.Fill();
                    }
                }
            }
            Console.WriteLine($"fuel level at the end:{fuelGauge.ReportLevel()}");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckOddEven(4));
            Console.ReadKey();

            string message = "Bye";
            
           
            MessageBox.Show(message);

        }

        static string CheckOddEven(int number)
        {
            if (number % 2 == 0)
            {
                return "Even Number";
            }
            else
            {
                return "Odd Number";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array1 = new int[10];
            int [] array2 = new int[10];
            Random random = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                int randomElement = random.Next(1, 101);
                array1[i] = randomElement;
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array1[i];
            }

            array1[array1.Length - 1] = -7;


            Console.WriteLine(string.Join(", ", array1));
            Console.WriteLine(string.Join(", ", array2));
            Console.ReadKey();
        }
    }
}

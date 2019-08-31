using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer and count the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            
            var n = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (n != 0)
            {
                n = n / 10;
                ++count;
            }
            

            //todo - check if Long
            if (n < 9223372036854775807) {
                //todo - check if n is less than zero
                if (n < 0) {
                    n *= -1;
                }
                //fixme
                if (n >= 10000000000) {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                } else {
                    int digits = 1;
                    if (count == 2) {
                        digits = 2;
                    } else if (count == 3) {
                        digits = 3;
                    } else if (count == 4) {
                        digits = 4;
                    } else if (count == 5) {
                        digits = 5;
                    } else if (count == 6) {
                        digits = 6;
                    } else if (count == 7) {
                        digits = 7;
                    } else if (count == 8) {
                        digits = 8;
                    } else if (count == 9) {
                        digits = 9;
                    } else if (count == 10) {
                        digits = 10;
                    }
                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            } else {
                Console.WriteLine("The number is not a long");
            }
            Console.ReadKey();


        }

    }

}

﻿using System;

namespace Exercise3
{
    class Program
    {
        //TODO: Write a C# program to calculate the average value of array elements.
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};


            //fixme - calculate sum of all array elements 
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);

            double average = (double)sum / (double)numbers.Length;

            //fixme - calculate average value 
            Console.WriteLine("Average value of the array elements is : " + string.Format("{0:F2}", average));


            Console.ReadKey();
        }
    }
}

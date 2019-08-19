﻿using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var name = "Zed A. Shaw";
            var age = 35;
            var height = 74;  // inches
            var weight = 180; // lbs
            var eyes = "Blue";
            var teeth = "White";
            var hair = "Brown";

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + Math.Round((height * 2.54), 2) + " centimeters tall.");
            Console.WriteLine("He's " + Math.Round((weight * 0.453592), 2) + " kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight
                               + " I get " + (age + height + weight) + ".");

            Console.ReadKey();
        }
    }
}
using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            //String myName, myEyes, myTeeth, myHair;
            //int myAge, myHeight, myWeight;

            string name = "Zed A. Shaw";
            int age = 35;
            int height = 74;  // inches
            int weight = 180; // lbs
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";

            string heightInCentimeters = string.Format("{0:F2}", (2.54 * height));
            string weightInKilograms = string.Format("{0:F2}", (0.453592 * weight));

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + height + " inches tall.");
            Console.WriteLine("He's " + weight + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + heightInCentimeters + ", and " + weightInKilograms
                               + " I get " + ((double)age + Convert.ToDouble(heightInCentimeters) + Convert.ToDouble(weightInKilograms)) + ".");

            Console.ReadKey();
        }
    }
}
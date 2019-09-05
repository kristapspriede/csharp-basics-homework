using System;
using System.Collections.Generic;
using System.IO;

namespace Histogram
{
    class Program
    {
        private const string Path = "C:/Users/krist/csharp-basics-homework/Collections//Histogram/midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path);
            //string[] newLines = readText.Split(' ');
            char[] delimiterChars = { ' ' };
            string[] words = readText.Split(delimiterChars);
            string tillten = "";
            string tilltwenty = "";
            string tillthirty = "";
            string tillforty = "";
            string tillfifty = "";
            string tillsixty = "";
            string tillseventy = "";
            string tilleighty = "";
            string tillninety = "";
            string tillhundred = "";
            string hundred = "";
            List<int> scores = new List<int>();
            foreach (var s in words)
            {
                scores.Add(Int32.Parse(s));
            }

            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] >= 0 && scores[i] <= 9)
                {
                    tillten += "*";
                }else if (scores[i] >= 10 && scores[i] <= 19)
                {
                    tilltwenty += "*";
                }
                else if (scores[i] >= 20 && scores[i] <= 29)
                {
                    tillthirty += "*";
                }
                else if (scores[i] >= 30 && scores[i] <= 39)
                {
                    tillforty += "*";
                }
                else if (scores[i] >= 40 && scores[i] <= 49)
                {
                    tillfifty += "*";
                }
                else if (scores[i] >= 50 && scores[i] <= 59)
                {
                    tillsixty += "*";
                }
                else if (scores[i] >=60 && scores[i] <= 69)
                {
                    tillseventy += "*";
                }
                else if (scores[i] >= 70 && scores[i] <= 79)
                {
                    tilleighty += "*";
                }
                else if (scores[i] >= 80 && scores[i] <= 89)
                {
                    tillninety += "*";
                }
                else if (scores[i] >= 90 && scores[i] <= 99)
                {
                    tillhundred += "*";
                }
                else if (scores[i] == 100)
                {
                    hundred += "*";
                }
            }

            Console.WriteLine("00 - 09: " + tillten);
            Console.WriteLine("10 - 19: " + tilltwenty);
            Console.WriteLine("20 - 29: " + tillthirty);
            Console.WriteLine("30 - 39: " + tillforty);
            Console.WriteLine("40 - 49: " + tillfifty);
            Console.WriteLine("50 - 59: " + tillsixty);
            Console.WriteLine("60 - 69: " + tillseventy);
            Console.WriteLine("70 - 79: " + tilleighty);
            Console.WriteLine("80 - 89: " + tillninety);
            Console.WriteLine("90 - 99: " + tillhundred);
            Console.WriteLine("    100: " + hundred);
            Console.ReadKey();



            //foreach (var i in scores)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadKey();
        }
    }
}
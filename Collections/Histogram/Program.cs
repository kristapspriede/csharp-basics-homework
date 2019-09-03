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

            List<int> scores = new List<int>();
            foreach (var s in words)
            {
                scores.Add(Int32.Parse(s));
            }

            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] >= 0 && scores[i] <= 9)
                {
                    Console.WriteLine("");
                }else if (scores[i] >= 10 && scores[i] <= 19)
                {
                    Console.WriteLine("*");
                }
                else if (scores[i] >= 20 && scores[i] <= 29)
                {
                    Console.WriteLine("*");
                }
                else if (scores[i] >= 30 && scores[i] <= 39)
                {
                    Console.WriteLine("**");
                }
                else if (scores[i] >= 40 && scores[i] <= 49)
                {
                    Console.WriteLine("*");
                }
                else if (scores[i] >= 50 && scores[i] <= 59)
                {
                    Console.WriteLine("*****");
                }
                else if (scores[i] >=60 && scores[i] <= 69)
                {
                    Console.WriteLine("*******");
                }
                else if (scores[i] >= 70 && scores[i] <= 79)
                {
                    Console.WriteLine("*****************");
                }
                else if (scores[i] >= 80 && scores[i] <= 89)
                {
                    Console.WriteLine("******");
                }
                else if (scores[i] >= 90 && scores[i] <= 99)
                {
                    Console.WriteLine("**********");
                }
                else if (scores[i] == 100)
                {
                    Console.WriteLine("*");
                }
            }




            //foreach (var i in scores)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadKey();
        }
    }
}
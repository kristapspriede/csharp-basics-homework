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
            
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            String[] array2 = { "English III", "Precalculus", "Music Theory", "Biotechnology", "Principles of Technology I", "Latin II", "AP US History", "Business Computer Infomation Systems" };
            String[] array3 = { "Ms. Lapan", "Mrs. Gideon", "Mr. Davis", "Ms. Palmer", "Ms. Garcia", "Mrs. Barnett", "Ms. Johannessen", "Mr. James" };

            int length1 = array2.Max(a => a.Length);
            int length2 = array3.Max(a => a.Length);


            Console.Write("+");
            string lines = new String('-', 60);
            Console.Write(lines);
            Console.WriteLine("+");

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("| " + array1[i] + " | " + new String(' ', length1- array2[i].Length) + array2[i] + " | " + new String(' ', length2 - array3[i].Length) + array3[i] + " |");
            }

            Console.Write("+");
            Console.Write(lines);
            Console.Write("+");
            Console.ReadKey();
        } 
    }
}

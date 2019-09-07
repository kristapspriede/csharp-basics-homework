using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> nameList = new HashSet<string>();
            var input = "";
            do
            {
                Console.WriteLine("Enter name:");
                input = Console.ReadLine();
                nameList.Add(input);
            } while (input != "");

            Console.Write("Unique name list contains: ");

            foreach (string i in nameList)
            {
                Console.Write(i + " ");
            }


            
            Console.ReadKey();

        }
    }
}

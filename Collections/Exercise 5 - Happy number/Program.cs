using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5___Happy_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Input any number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int currentNumber = num;
            List<int> digits = new List<int>();


            while (currentNumber != 0)
            {
                digits.Add(currentNumber % 10);
                currentNumber = currentNumber / 10;
            }
            digits.Reverse();

            do
            {
                foreach (var item in digits)
                {
                    sum += item * item;
                }
                Console.WriteLine(sum);
                if (sum == 1)
                {
                    Console.WriteLine("Happy number!");
                    break;
                } else if (sum < 10 && sum > 1)
                {
                    Console.WriteLine("Not a happy number!");
                    break;
                }
                digits.Clear();
                while (sum != 0)
                {
                    digits.Add(sum % 10);
                    sum = sum / 10;
                }
                digits.Reverse();
                sum = 0;
            } while (true);
            Console.ReadKey();
        }
    }
}

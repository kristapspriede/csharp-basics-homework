using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = 0;
            double withdrawalAmount = 0;
            double interest = 0;
            

            Console.Write("How much money is in the account?: ");
            var balance = Double.Parse(Console.ReadLine());
            var account1 = new SavingsAccount(balance);
            Console.Write("Enter the annual interest rate: ");
            double rate = Int32.Parse(Console.ReadLine());
            Console.Write("How long has the account been opened? ");
            var month = Int16.Parse(Console.ReadLine());
            for (int i = 1; i <= month; i++)
            {
                Console.Write("Enter amount deposited for month: " + i +": ");
                var deposit = Double.Parse(Console.ReadLine());
                account1.Deposit(deposit);
                depositAmount += deposit;

                Console.Write("Enter amount withdrawn for month: " + i + ": ");
                var withdrawal = Double.Parse(Console.ReadLine());
                account1.Withdrawal(withdrawal);
                withdrawalAmount += withdrawal;
                //account1.Interest(balance);
                interest += (balance + deposit - withdrawal) * (rate / 12);

            }

            Console.WriteLine("Total deposited: $" + string.Format("{0:F2}", depositAmount));
            Console.WriteLine("Total withdrawn: $" + string.Format("{0:F2}", withdrawalAmount));
            Console.WriteLine("Interest earned: $" + string.Format("{0:F2}", interest));
            //Console.WriteLine("Ending balance: $" +
                              //string.Format("{0:$C2}", (account1.Balance() + depositAmount - withdrawalAmount +
                               //(account1.Interest(rate) * month))));
            Console.WriteLine("Ending balance: $" + string.Format("{0:F2}", interest + account1.EndingBalance(balance, depositAmount, withdrawalAmount)));
            Console.ReadKey();
        }
    }
}

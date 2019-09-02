using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var bartosAccount = new Account("Barto's account", 100.00);
            var bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00);

            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount.ShowUserNameAndBalance());
            Console.WriteLine(bartosSwissAccount.ShowUserNameAndBalance());

            
            bartosAccount.Withdrawal(20);
            Console.WriteLine("Barto's account balance is now: "+bartosAccount.Balance());
            bartosSwissAccount.Deposit(200);
            Console.WriteLine("Barto's Swiss account balance is now: "+bartosSwissAccount.Balance());
            

            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount.ShowUserNameAndBalance());
            Console.WriteLine(bartosSwissAccount.ShowUserNameAndBalance());
            Console.WriteLine();

            var mattsAccount = new Account("Matt's account", 1000.00);
            var myAccount = new Account("My Account", 0);

            mattsAccount.Withdrawal(100);
            myAccount.Deposit(100);
            Console.WriteLine(mattsAccount.ShowUserNameAndBalance());
            Console.WriteLine(myAccount.ShowUserNameAndBalance());

            var AAccount = new Account("A account", 100.00);
            var BAccount = new Account("B Account", 0);
            var CAccount = new Account("C Account", 0);

            AAccount.Transfer(AAccount, BAccount, 50.0);
            AAccount.Transfer(BAccount, CAccount, 25.0);
            Console.WriteLine(AAccount.ShowUserNameAndBalance());
            Console.WriteLine(BAccount.ShowUserNameAndBalance());
            Console.WriteLine(CAccount.ShowUserNameAndBalance());
            Console.ReadKey();
        }
    }
}

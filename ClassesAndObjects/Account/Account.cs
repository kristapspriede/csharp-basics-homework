using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private string _account;
        private double _balance;
        

        public Account(string account, double money)
        {
            _account = account;
            _balance = money;
        }

        public void Withdrawal(double moneyWithdrawal)
        {
            _balance -= moneyWithdrawal;
        }
        public void Deposit(double moneyDeposit)
        {
            _balance += moneyDeposit;
        }

        public double Balance()
        {
            return _balance;
        }
        public string ShowUserNameAndBalance()
        {
            return (_account + ": " + _balance);
        }

        public  void Transfer(Account from, Account to, double howMuch)
        {
            from._balance -= howMuch;
            to._balance += howMuch;
        }
    }
}

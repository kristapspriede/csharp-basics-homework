using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class SavingsAccount
    {
        private double _balance;
        private double _deposit;
        private double _withdrawal;
        private double _rate;

        
        //double _interestAmount;

        public SavingsAccount(double balance)
        {
            _balance = balance;
            
        }
        public double Balance()
        {
            return _balance;
        }

        public double Deposit(double deposit)
        {
            _deposit = deposit;
            return _balance + _deposit;
        }
        public double Withdrawal(double withdrawal)
        {
            _withdrawal = withdrawal;
            return _balance - _withdrawal;
        }

        public double Interest(double balance)
        {
            _balance = balance;
            return (_rate / 12) * _balance;
        }

        public double EndingBalance(double balance, double depositAmount, double withdrawalAmount)
        {
            return balance + depositAmount - withdrawalAmount;
        }

    }
}

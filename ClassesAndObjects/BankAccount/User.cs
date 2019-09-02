using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class User
    {
        string _name;
        double _balance;

        public User(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }


        public string ShowUserNameAndBalance()
        {
            
            if (_balance < 0)
            {
                return (_name + ", -$" + _balance * -1);
            }
            else
            {
                return (_name + ", $" + _balance);
            }

        }
    }
}

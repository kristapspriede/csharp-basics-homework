using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            User benben = new User("Benson",-17.98 );
            Console.WriteLine(benben.ShowUserNameAndBalance());
            Console.ReadKey();
        }
        
    }
}

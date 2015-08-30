using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual Celin = new Individual("Celin");
            Company Dion = new Company("Dion");

            Loan loanAcc = new Loan(Celin, 1, 7.5);
            Deposit depositAcc = new Deposit(Dion, 33000, 20);

            loanAcc.DepositAmount(100);
            Console.WriteLine(loanAcc.Balance);

            depositAcc.WithdrawAmount(5000);
            Console.WriteLine(depositAcc.Balance);

            Console.WriteLine(depositAcc.InterestAmount(12));
        }
    }
}

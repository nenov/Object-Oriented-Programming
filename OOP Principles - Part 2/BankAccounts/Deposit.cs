using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class Deposit : Account, ICanWithdraw, ICanDeposit
    {
        public Deposit(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        { 
        
        }
    
        public void WithdrawAmount(double amm)
        {
            this.Balance -= amm;
        }

        public void DepositAmount(double amm)
        {
            this.Balance += amm;
        }

        public override double InterestAmount(int numOfMonths)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                throw new ArgumentException("Interest amount cannot be calculated with positive balance less than 1000");
            }

            return base.InterestAmount(numOfMonths);
        }
    }
}

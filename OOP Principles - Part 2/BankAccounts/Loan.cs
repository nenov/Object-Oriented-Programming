using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class Loan : Account, ICanDeposit
    {
        public Loan(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        { 
        
        }
    
        public void DepositAmount(double amm)
        {
            this.Balance += amm;
        }
        public override double InterestAmount(int numOfMonths)
        {
            if (this.Customer is Individual)
            {
                numOfMonths -= 3;
            }
            else if (this.Customer is Company)
            {
                numOfMonths -= 2;
            }
            if (numOfMonths < 0)
            {
                return 0;
            }

            return numOfMonths * this.InterestRate;
        }
    }
}

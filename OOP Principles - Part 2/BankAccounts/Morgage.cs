using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class Morgage : Account, ICanDeposit
    {
        public Morgage(Customer customer, double balance, double interestRate)
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
                numOfMonths -= 6;
            }
            else if (this.Customer is Company)
            {
                if (numOfMonths <= 12)
                {
                    return 0.5 * base.InterestAmount(numOfMonths);
                }
                else
                {
                    double result = 0.5 * base.InterestAmount(12);
                    result += base.InterestAmount(numOfMonths - 12);
                    return result;
                }
            }
            if (numOfMonths < 0)
            {
                return 0;
            }

            return base.InterestAmount(numOfMonths);
        }
    }
}

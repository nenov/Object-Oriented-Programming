using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public abstract class Account
    {
        private Customer customer;
        private double balance;
        private double interestRate;

        public Account(Customer cus, double bal,double inte)
        {
            this.Customer = cus;
            this.Balance = bal;
            this.InterestRate = inte;
        }

        public double InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public virtual double InterestAmount(int numOfMonths)
        {
            return numOfMonths * this.InterestRate;
        }
    }
}

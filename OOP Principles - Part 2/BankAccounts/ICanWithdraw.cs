using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public interface ICanWithdraw
    {
        void WithdrawAmount(double ammount);
    }
}

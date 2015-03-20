using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class CheckingAccount : BankAccount
    {
        public override void Withdraw(double amount)
        {
            if (this.balance >= amount)
                this.balance = this.balance - amount;
        }
    }
}

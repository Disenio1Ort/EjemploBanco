using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class SavingsAccount : BankAccount
    {
        public override void Withdraw(double amount)
        {
            this.balance -= amount;
        }
    }
}

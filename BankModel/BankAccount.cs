using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public abstract class BankAccount
    {
        private int id;
        protected double balance = 0;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public virtual void Deposit(double amount)
        {
            this.balance += amount;
        }

        public abstract void Withdraw(double amount);

        public virtual double CheckBalance()
        {
            return this.balance;
        }
    }
}

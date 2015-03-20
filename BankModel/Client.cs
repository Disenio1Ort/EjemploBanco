using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class Client
    {
        private int id;
        private string name;
        private string lastName;
        private List<BankAccount> accounts;

        public Client()
        {
            this.accounts = new List<BankAccount>();
        }

        public Client(int id, string name, string lastName) : this()
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public void AddAccount(BankAccount cb)
        {
            this.accounts.Add(cb);
        }

        public void RemoveAccount(int idCuenta)
        {
            for (int i = 0; i < this.accounts.Count; i++)
            {
                if (this.accounts[i].Id == this.id)
                {
                    this.accounts.Remove(this.accounts[i]);
                    break;
                }
            }
        }

        public List<BankAccount> GetAccounts()
        {
            return this.accounts;
        }

        public override string ToString()
        {
            return this.Name + " " + this.LastName;
        }
    }
}

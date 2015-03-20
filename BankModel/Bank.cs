using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class Bank
    {
        private static Bank bankInstance = null;
        public static Bank GetInstance()
        {
            if (bankInstance == null)
                bankInstance = new Bank();

            return bankInstance;
        }

        private List<Client> clients;

        public Bank()
        {
            this.clients = new List<Client>();
        }

        public void AddClient(Client client)
        {
            this.clients.Add(client);
        }

        public void RemoveClient(int id)
        {
            for (int i = 0; i < this.clients.Count; i++)
            {
                if (this.clients[i].Id == id)
                {
                    this.clients.Remove(clients[i]);
                    break;
                }
            }
        }

        public Client GetClientById(int id)
        {
            for (int i = 0; i < this.clients.Count; i++)
            {
                if (this.clients[i].Id == id)
                {
                    return this.clients[i];
                }
            }

            return null;
        }
    }
}

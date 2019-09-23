using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Entities
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
        public string Email { get; set; }
        public List<BankAccount> GetBankAccounts { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Entities
{
    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
        public string Email { get; set; }
        public List<BankAccount> GetBankAccounts { get; }
    }
}

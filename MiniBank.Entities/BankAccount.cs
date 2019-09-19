using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Entities
{
   public class BankAccount
    {
        public int AccountNumber { get; set; }
        public double InterestRate { get; set; }
        public double ActualBalance { get; set; }
        public List<Transaction> GetAllTransactions { get; }
        public List<Customer> GetAllCusmtomers { get; }
    }
}

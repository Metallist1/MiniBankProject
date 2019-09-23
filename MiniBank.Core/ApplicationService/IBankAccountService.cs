using MiniBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.ApplicationService
{
   public interface IBankAccountService
    {
        List<BankAccount> readAllBankAccounts();
        BankAccount CreateAccount(double intrestRate, double actualBalance);
        BankAccount ReadAccByID(int id);
        BankAccount UpdateAccount(BankAccount bA);
        BankAccount DeleteAcc(int id);
        void WithdrawMoney(BankAccount bA, double amount);
        void DepositMoney(BankAccount bA, double amount);
    }
}

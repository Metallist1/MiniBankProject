using MiniBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.ApplicationService
{
   public interface IBankAccountService
    {
        BankAccount newBankAccount(double intrestRate, double actualBalance);
        int CreateAccount(BankAccount bA);
        BankAccount ReadAccByID(int id);
        bool UpdateAccount(BankAccount bA);
        bool DeleteAcc(int id);
        void WithdrawMoney(BankAccount bA, double amount);
        void DepositMoney(BankAccount bA, double amount);
    }
}

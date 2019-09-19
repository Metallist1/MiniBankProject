using System;
using System.Collections.Generic;
using System.Text;
using MiniBank.Core.DomainService;
using MiniBank.Entities;

namespace MiniBank.Core.ApplicationService.AppliactionService.Impl
{
    public class BankAccountService : IBankAccountService
    {
        IBankAccountRepository repo;
        public BankAccountService(IBankAccountRepository repo) {
            this.repo = repo;
        }
        public BankAccount newBankAccount(double intrestRate, double actualBalance)
        {
            Random rnd = new Random();
            int number = rnd.Next(int.MaxValue);
            var account = new BankAccount { InterestRate = intrestRate, ActualBalance = actualBalance, AccountNumber = number };
            return account;
        }
        public int CreateAccount(BankAccount bA)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAcc(int id)
        {
            throw new NotImplementedException();
        }

        public void DepositMoney(BankAccount bA, double amount)
        {
            bA.ActualBalance =+ amount;
            UpdateAccount(bA);
        }
        public void WithdrawMoney(BankAccount bA, double amount)
        {
            bA.ActualBalance =- amount;
            UpdateAccount(bA);
        }
        public BankAccount ReadAccByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAccount(BankAccount bA)
        {
            DeleteAcc(bA.AccountNumber);
            CreateAccount(bA);
            return true;
        }

  
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using MiniBank.Core.DomainService;
using MiniBank.Entities;

namespace MiniBank.Core.ApplicationService.AppliactionService.Impl
{
    public class BankAccountService : IBankAccountService
    {
       private IBankAccountRepository _repo;
        public BankAccountService(IBankAccountRepository repo) {
            _repo = repo;
        }
        private BankAccount newBankAccount(double intrestRate, double actualBalance)
        {
            Random rnd = new Random();
            int number = rnd.Next(int.MaxValue);
            var account = new BankAccount {
                InterestRate = intrestRate,
                ActualBalance = actualBalance,
                AccountNumber = number
            };
            return account;
        }
        public BankAccount CreateAccount(double intrestRate, double actualBalance)
        {
            var newBankAcc = newBankAccount(intrestRate, actualBalance);
            return _repo.Create(newBankAcc);
        }

        public BankAccount DeleteAcc(int id)
        {
            return _repo.Delete(id);
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
            return _repo.ReadByID(id);
        }

        public BankAccount UpdateAccount(BankAccount bA)
        {
            return _repo.Update(bA);
        }

        public List<BankAccount> readAllBankAccounts()
        {
            return _repo.ReadAllBankAccounts();
        }
    }
}

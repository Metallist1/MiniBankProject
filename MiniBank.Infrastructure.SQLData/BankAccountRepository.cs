using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MiniBank.Core.DomainService;
using MiniBank.Entities;

namespace MiniBank.Infrastructure.SQLData
{
    public class BankAccountRepository : IBankAccountRepository
    {
         readonly MiniBankAppContext _ctx;

        public BankAccountRepository (MiniBankAppContext ctx)
        {
            _ctx = ctx;
        }
        public BankAccount Create(BankAccount bcToCreate)
        {
            var bc = _ctx.BankAccounts.Add(bcToCreate).Entity;
            _ctx.SaveChanges();
            return bc;
        }

        public BankAccount Delete(int bcToDelete)
        {
            var custRemoved = _ctx.Remove(new BankAccount { id = bcToDelete }).Entity;
            _ctx.SaveChanges();
            return custRemoved;
        }

        public List<BankAccount> ReadAllBankAccounts()
        {
            return _ctx.BankAccounts.ToList();
        }

        public BankAccount ReadByID(int IdToFind)
        {
            return _ctx.BankAccounts.FirstOrDefault(c => c.id == IdToFind);
        }

        public BankAccount Update(BankAccount bcToUpdate)
        {
            var custUpdated = _ctx.Update<BankAccount>(bcToUpdate).Entity;
            _ctx.SaveChanges();
            return custUpdated;
        }
    }
}

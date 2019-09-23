using MiniBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.DomainService
{
    public interface IBankAccountRepository
    {
        BankAccount Create(BankAccount bcToCreate);

        List<BankAccount> ReadAllBankAccounts();

        BankAccount Update(BankAccount bcToUpdate);

        BankAccount Delete(int bcToDelete);
        BankAccount ReadByID(int IdToFind);

    }
}

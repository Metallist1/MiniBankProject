using MiniBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.ApplicationService
{
   public interface IBankAccountService
    {
        BankAccount newBankAccount();
    }
}

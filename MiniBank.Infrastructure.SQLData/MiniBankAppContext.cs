using Microsoft.EntityFrameworkCore;
using MiniBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Infrastructure.SQLData
{
   public class MiniBankAppContext : DbContext
    {
        public MiniBankAppContext(DbContextOptions<MiniBankAppContext> opt) 
            : base(opt) {}

        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

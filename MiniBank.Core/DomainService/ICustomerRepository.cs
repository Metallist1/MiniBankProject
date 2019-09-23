using System;
using System.Collections.Generic;
using System.Text;
using MiniBank.Entities;

namespace MiniBank.Core.DomainService
{
    public interface ICustomerRepository
    {
        Customer Create(Customer cust);
        Customer Delete(int id);
        List<Customer> readAll();
        Customer readByID(int id);
        Customer Update(Customer cust);
    }
}

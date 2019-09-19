using MiniBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.ApplicationService
{
    public interface ICustomerService
    {
        Customer newCustomer(string name, string Address, int Number, string email);
        int CreateCustomer(Customer cust);
        Customer ReadCustByID(int id);
        List<Customer> GetAllCustomers();
        bool UpdateCustomer(Customer cust);
        bool DeleteCustomer(int id);
    }
}

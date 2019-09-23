using MiniBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.ApplicationService
{
    public interface ICustomerService
    {
        Customer CreateCustomer(Customer cust);
        Customer ReadCustByID(int id);
       
        List<Customer> GetAllCustomers();
        Customer UpdateCustomer(Customer cust);
        Customer DeleteCustomer(int id);
    }
}

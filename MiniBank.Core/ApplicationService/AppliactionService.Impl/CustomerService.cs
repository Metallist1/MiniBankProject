using System;
using System.Collections.Generic;
using System.Text;
using MiniBank.Entities;

namespace MiniBank.Core.ApplicationService.AppliactionService.Impl
{
    public class CustomerService : ICustomerService
    {

        public int CreateCustomer(Customer cust)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }
        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }
        public Customer newCustomer(string name, string address, int number, string email)
        {
            var cust = new Customer { Name = name, Address = address, Number = number, Email = email };
            return cust;
        }

        public Customer ReadCustByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(Customer cust)
        {
            DeleteCustomer(cust.Number);
            CreateCustomer(cust);
            return true;
        }
    }
}

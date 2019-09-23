using System;
using System.Collections.Generic;
using System.Text;
using MiniBank.Core.DomainService;
using MiniBank.Entities;

namespace MiniBank.Core.ApplicationService.AppliactionService.Impl
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customer;
        public CustomerService(ICustomerRepository customer)
        {
            _customer = customer;
        }

        public Customer CreateCustomer(Customer cust)
        {
            return _customer.Create(cust);
        }

        public Customer DeleteCustomer(int id)
        {
            return _customer.Delete(id);
        }
        public List<Customer> GetAllCustomers()
        {
           return _customer.readAll();
        }

        public Customer ReadCustByID(int id)
        {
            return _customer.readByID(id);
        }

        public Customer UpdateCustomer(Customer cust)
        {
            return _customer.Update(cust);
        }
    }
}

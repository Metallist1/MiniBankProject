using MiniBank.Core.DomainService;
using MiniBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Infrastructure.SQLData
{
    public class CustomerRepository : ICustomerRepository
    {
        readonly MiniBankAppContext _ctx;
        public CustomerRepository(MiniBankAppContext ctx)
        {
            _ctx = ctx;
        }

        public Customer Create(Customer cust)
        {
            throw new NotImplementedException();
        }

        public Customer Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> readAll()
        {
            throw new NotImplementedException();
        }

        public Customer readByID(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer cust)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniBank.Core.ApplicationService;
using MiniBank.Entities;

namespace MiniBankProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {

        IBankAccountService _service;
        public BankAccountController(IBankAccountService bankAccountService) {
            _service = bankAccountService;
        }
       
        [HttpGet]
        public ActionResult<List<BankAccount>> Get()
        {
            return _service.readAllBankAccounts();
        }

        
        [HttpGet("{id}")]
        public ActionResult<BankAccount> Get(int id)
        {
            return _service.ReadAccByID(id);
        }

        
        [HttpPost]
        public ActionResult<BankAccount> Post([FromBody] BankAccount bankAccount)
        {
            return _service.CreateAccount(bankAccount.InterestRate , bankAccount.ActualBalance);
        }

        
        [HttpPut("{id}")]
        public ActionResult<BankAccount> Put(int id, [FromBody] BankAccount bankAccount)
        {
            return _service.UpdateAccount(bankAccount);
        }

        
        [HttpDelete("{id}")]
        public ActionResult<BankAccount> Delete(int id)
        {
           return _service.DeleteAcc(id);
        }
    }
}

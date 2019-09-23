using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MiniBank.Core.DomainService;
using MiniBank.Infrastructure.SQLData;
using MiniBank.Core.ApplicationService;
using MiniBank.Core.ApplicationService.AppliactionService.Impl;
using Microsoft.EntityFrameworkCore;
using MiniBank.Entities;

namespace MiniBankProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MiniBankAppContext>(
                opt => opt.UseInMemoryDatabase("ThatDB")
                ) ;

            services.AddScoped<IBankAccountRepository, BankAccountRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IBankAccountService, BankAccountService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var ctx = scope.ServiceProvider.GetService<MiniBankAppContext>();
                    //Seed customers

                    var customer1 = ctx.Customers.Add(new Customer()
                    {
                        id = 95,
                        Name = "John",
                        Address = "Meme Street",
                        Number = 25,
                        Email = "JohnSmith@hotmail.com"
                    }).Entity;

                    var customer2 = ctx.Customers.Add(new Customer()
                    {
                        id = 98,
                        Name = "Kent",
                        Address = "Kent Street",
                        Number = 95,
                        Email = "Kent@hotmail.com"
                    }).Entity;

                    //Seed BankAccounts

                    var BankAcc1 = ctx.BankAccounts.Add(new BankAccount()
                    {
                        id = 93,
                        ActualBalance = 25,
                        InterestRate = 1.2
                    }).Entity;

                    var BankAcc2 = ctx.BankAccounts.Add(new BankAccount()
                    {
                        id = 103,
                        ActualBalance = 29,
                        InterestRate = 1.9
                    }).Entity;

                    ctx.SaveChanges();
                }
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

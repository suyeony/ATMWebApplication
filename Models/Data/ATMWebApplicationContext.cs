using System;
using Microsoft.EntityFrameworkCore;
using ATMWebApplication.Models;

namespace ATMWebApplication.Data
{
    public class ATMWebApplicationContext : DbContext
    {
        public ATMWebApplicationContext(DbContextOptions<ATMWebApplicationContext> options)
            : base(options)
        {

        }

        public DbSet<Customer> Customer { get; set; }
    }
}

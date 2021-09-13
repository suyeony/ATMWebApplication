using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ATMWebApplication.Data;
using System;
using System.Linq;

namespace ATMWebApplication.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ATMWebApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ATMWebApplicationContext>>()))
            {
                // Look for any movies.
                if (context.Customer.Any())
                {
                    return;   // DB has been seeded
                }

                context.Customer.AddRange(
                    new Customer
                    {
                        FullName = "Suyeon Yang",
                        AccountNum = "12345678",
                        Pin = "1234",
                        Balance = 250
                    },
                    new Customer
                    {
                        FullName = "Ella Lee",
                        AccountNum = "910111213",
                        Pin = "5678",
                        Balance = 1000
                    }              
                );

                context.SaveChanges();
            }
        }
    }
}

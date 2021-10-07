using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toppings.Data.Models;

namespace Toppings.Data
{
    public class ToppingDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ToppingDbContext>();
                if (!context.Toppings.Any())
                {
                    context.Toppings.AddRange(
                       new Topping() { Name = "Tomato", Price = 99 },
                       new Topping() { Name = "Cheese", Price = 89 },
                       new Topping() { Name = "Onion", Price = 100 });
                    context.SaveChanges();
                }
            }
        }
    }
}

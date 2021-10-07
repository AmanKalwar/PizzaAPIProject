using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toppings.Data.Models;

namespace Toppings.Data
{
    public class ToppingDbContext:DbContext
    {
        public ToppingDbContext(DbContextOptions<ToppingDbContext> options) : base(options)
        {

        }
        public DbSet<Topping> Toppings { get; set; }
    }
}

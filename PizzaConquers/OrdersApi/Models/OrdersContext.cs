using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Models
{
    public class OrdersContext:DbContext
    {
        public OrdersContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Orders> Orders { get; set; }
    }
}

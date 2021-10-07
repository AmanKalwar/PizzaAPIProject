using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderDetails.Models
{
    public class OrdersContext:DbContext
    {
        public OrdersContext(DbContextOptions options):base(options)
        {

        }
    
       public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}

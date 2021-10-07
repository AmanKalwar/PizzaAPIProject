using Microsoft.EntityFrameworkCore;
using OrdersApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Services
{
    public class OrdersService
    {
        private readonly OrdersContext _context;

        public OrdersService(OrdersContext context)
        {
            _context = context;
        }
        public Orders Add(Orders orders)
        {
            try
            {
                _context.Orders.Add(orders);
                _context.SaveChanges();
                return _context.Orders.Where(e => e.CustomerID == orders.CustomerID).ToList()[_context.Orders.Where(e => e.CustomerID == orders.CustomerID).ToList().Count - 1];
            }
            catch (DbUpdateConcurrencyException Dbce)
            {
                Console.WriteLine(Dbce.Message);
            }
            catch (DbUpdateException Dbe)
            {
                Console.WriteLine(Dbe.Message);
            }
            return null;
        }
    }
}

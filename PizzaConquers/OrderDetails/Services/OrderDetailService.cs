using Microsoft.EntityFrameworkCore;
using OrderDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderDetails.Services
{
    public class OrderDetailService
    {

        private readonly OrdersContext _context;

        public OrderDetailService(OrdersContext context)
        {
            _context = context;
        }
        public OrderDetail Add(OrderDetail orders)
        {
            try
            {
                _context.OrderDetails.Add(orders);
                _context.SaveChanges();
                return _context.OrderDetails.Where(e => e.OrderID == orders.OrderID).ToList()[_context.OrderDetails.Where(e => e.OrderID == orders.OrderID).ToList().Count - 1];
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toppings.Data.Models;

namespace Toppings.Data.Services
{
    public class ToppingService
    {
        private ToppingDbContext _context;

        public ToppingService(ToppingDbContext context)
        {
            _context = context;
        }

        public List<Topping> GetAllToppings()
        {
            return _context.Toppings.ToList();

        }

        public Topping GetToppingById(int bookId)
        {
            return _context.Toppings.FirstOrDefault(n => n.ID == bookId);

        }
    }
}

using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Services
{
    public class PizzaService
    {
        private readonly PizzaContext _context;

        public PizzaService(PizzaContext context)
        {
            _context = context;
        }

        public Pizza Get(int id)
        {
            Pizza pizza = null;
            try
            {
                pizza = _context.Pizzas.FirstOrDefault(e => e.ID == id);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return pizza;
        }

        public ICollection<Pizza> GetAll()
        {
            ICollection<Pizza> employees = _context.Pizzas.ToList();
            if (employees.Count > 0)
                return employees;
            else
                return null;
        }
    }
}

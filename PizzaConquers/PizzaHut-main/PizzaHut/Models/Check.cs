using PizzaHut.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaHut.Models
{
    public class Check
    {
        public ICollection<ToppingsDTO> Toppings {get; set; }
        public int checks { get; set; }
    }
}

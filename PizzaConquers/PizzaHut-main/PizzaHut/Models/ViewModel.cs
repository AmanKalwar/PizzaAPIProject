using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaHut.Models
{
    public class ViewModel
    {
        public PizzaDTO pizza { get; set; }
        public ICollection<ToppingsDTO> Toppings{get; set;}
    }
}

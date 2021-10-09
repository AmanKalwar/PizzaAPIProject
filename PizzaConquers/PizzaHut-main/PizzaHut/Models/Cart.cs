using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaHut.Models
{
    public class Cart
    {
        public PizzaDTO Pizza { get; set; }
        public int Qty { get; set; }
    }
}

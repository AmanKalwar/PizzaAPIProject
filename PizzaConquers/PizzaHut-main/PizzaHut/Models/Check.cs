using PizzaHut.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaHut.Models
{
    public class Check
    {
        public bool IsSelected { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
    }
}

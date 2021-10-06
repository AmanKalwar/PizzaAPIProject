using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Models
{
    public class PizzaDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Crust { get; set; }
        public string Images { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}

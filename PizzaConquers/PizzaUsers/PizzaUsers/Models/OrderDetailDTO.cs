using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaUsers.Models
{
    public class OrderDetailDTO
    {
        public int ID { get; set; }
        public int OrderID { get; set; }

        public int ToppingsID { get; set; }
        public string ToppingsName { get; set; }
    }
}

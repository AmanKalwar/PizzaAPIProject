using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Models
{
    public class Orders
    {

        [Key]
        public int OrderID { get; set; }
        public int PizzaID { get; set; }
        public int CustomerID { get; set; }
        public string Address { get; set; }
        public string PizzaName { get; set; }
        public double Price { get; set; }

        public DateTime date { get; set; }
        public int Qty { get; set; }

    }
}

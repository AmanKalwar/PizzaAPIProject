using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderDetails.Models
{
    public class OrderDetail
    {
        [Key]
        public int ID { get; set; }
        public int OrderID { get; set; }
      
        public int ToppingsID { get; set; }
        public string ToppingsName { get; set; }
     
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Models
{
    public class Employee
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

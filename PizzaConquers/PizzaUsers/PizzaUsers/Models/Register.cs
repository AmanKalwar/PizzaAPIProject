using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaUsers.Models
{
    public class Register
    {


        public string Email { get; set; }
        public string Password { get; set; }

        public string Re_Password { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
        public string jwtToken { get; set; }
    }
}

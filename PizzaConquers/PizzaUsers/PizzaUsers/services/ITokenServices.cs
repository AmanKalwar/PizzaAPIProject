using PizzaUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaUsers.services
{
   public interface ITokenServices
    {
        public string CreateToken(UserDTO userDTO);
    }
}

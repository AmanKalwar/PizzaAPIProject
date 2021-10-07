using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaUsers.Models;
using PizzaUsers.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaUsers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly OrderServices _Oservices;

        public OrderController(OrderServices orderServices)
        {
            _Oservices = orderServices;
        }
       

        // POST api/<OrderController>
        [HttpPost]
        public async Task<ActionResult<OrderDTO>> Post([FromBody] OrderDTO order)
        {
            OrderDTO order1 = _Oservices.Add(order);
            if (order1 != null)
            {
                return order1;
            }
            return BadRequest("Couldnt Add");
        }

    }
}

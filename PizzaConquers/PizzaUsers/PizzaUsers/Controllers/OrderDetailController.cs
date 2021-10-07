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
    public class OrderDetailController : ControllerBase
    {
        private readonly OrderDetailServices _Odservices;

        public OrderDetailController(OrderDetailServices orderDetailServices)
        {
            _Odservices = orderDetailServices;
        }
        // POST api/<OrderDetailController>
        [HttpPost]
        public async Task<ActionResult<OrderDetailDTO>> Post([FromBody] OrderDetailDTO order)
        {
            OrderDetailDTO order1 = _Odservices.Add(order);
            if (order1 != null)
            {
                return order1;
            }
            return BadRequest("Couldnt Add");
        }
    }
}

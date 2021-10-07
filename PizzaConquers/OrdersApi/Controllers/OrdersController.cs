using Microsoft.AspNetCore.Mvc;
using OrdersApi.Models;
using OrdersApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrdersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrdersService _service;

        public OrdersController(OrdersService service)
        {
            _service = service;
        }
       
        [HttpPost]
        public async Task<ActionResult<Orders>> Post([FromBody] Orders order)
        {
            Orders orders = _service.Add(order);
            if (orders != null)
            {
                return orders;
            }
            return BadRequest("Couldnt Add");
        }
        
    }
}

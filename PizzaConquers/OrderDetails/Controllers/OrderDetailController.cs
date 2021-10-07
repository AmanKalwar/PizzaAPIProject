using Microsoft.AspNetCore.Mvc;
using OrderDetails.Models;
using OrderDetails.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly OrderDetailService _service;

        public OrderDetailController(OrderDetailService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<OrderDetail>> Post([FromBody] OrderDetail order)
        {
            OrderDetail orders = _service.Add(order);
            if (orders != null)
            {
                return orders;
            }
            return BadRequest("Couldnt Add");
        }
    }
}

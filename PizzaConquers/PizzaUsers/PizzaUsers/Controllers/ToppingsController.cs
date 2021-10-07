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
    public class ToppingsController : ControllerBase
    {
        private readonly ToppingsService _Tservices;

        public ToppingsController(ToppingsService toppingsService)
        {
            _Tservices = toppingsService;
        }
        // GET: api/<ToppingsController>
        [Route("GetToppings")]
        [HttpGet]

        public ICollection<ToppingsDTO> GetToppings()
        {
            if (_Tservices.GetAllToppings() != null)
            {
                return _Tservices.GetAllToppings();
            }
            return null;
        }

        // GET api/<ToppingsController>/5
        [HttpGet("{id}")]
        public ToppingsDTO Get(int id)
        {
            ToppingsDTO  toppings = _Tservices.GetToppingById(id);
            if (toppings != null)
            {
                return toppings;
            }
            return toppings;
        }

        
       
    }
}

using Microsoft.AspNetCore.Mvc;
using PizzaAPI.Models;
using PizzaAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaService _pizzaService;

        public PizzaController(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        // GET: api/<PizzaController>
        [HttpGet]
        public IEnumerable<Pizza> Get()
        {
            if (_pizzaService.GetAll() != null) {
                  
                return _pizzaService.GetAll();
            }
             
            return null;
        }

        // GET api/<PizzaController>/5
        [HttpGet("{id}")]
        public Pizza Get(int id)
        {
            return _pizzaService.Get(id);
        }

        // POST api/<PizzaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PizzaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PizzaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

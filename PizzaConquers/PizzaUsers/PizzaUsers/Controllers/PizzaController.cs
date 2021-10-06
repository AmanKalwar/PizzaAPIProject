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
    public class PizzaController : ControllerBase
    {
        private readonly PizzaService _pservice;

        public PizzaController(PizzaService pizzaService)
        {
            _pservice = pizzaService;
        }
        // GET: api/<PizzaController>
        [Route("GetPizza")]
        [HttpGet]
       
        public ICollection<PizzaDTO> GetPizza()
        {
            if (_pservice.GetAll() != null)
            {
                return _pservice.GetAll();
            }
            return null;
        }

        // GET api/<PizzaController>/5
        [HttpGet("{id}")]
        public PizzaDTO Get(int id)
        {
            PizzaDTO pizza = _pservice.Get(id);
            if (pizza!= null)
            {
                return pizza;
            }
            return pizza;
        }
        // DELETE api/<PizzaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

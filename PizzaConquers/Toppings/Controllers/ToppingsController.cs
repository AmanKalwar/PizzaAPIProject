using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toppings.Data.Services;

namespace Toppings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToppingsController : ControllerBase
    {
        public ToppingService _topingsService;
        public ToppingsController(ToppingService booksService)
        {
            _topingsService = booksService;
        }

        [HttpGet("get-all-toppings")]
        public IActionResult GetAllBooks()
        {
            var allTops = _topingsService.GetAllToppings();
            return Ok(allTops);
        }

        [HttpGet("get-topping-by-id/{id}")]
        public IActionResult GetBookById(int id)
        {
            var tops = _topingsService.GetToppingById(id);
            return Ok(tops);
        }
    }
}

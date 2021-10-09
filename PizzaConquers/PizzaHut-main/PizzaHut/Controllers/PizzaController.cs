using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaHut.Models;
using PizzaHut.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaHut.Controllers
{
    public class PizzaController : Controller
    {
        private ILogger<PizzaController> _logger;
        private readonly PizzaRepo _PRepo;

        public PizzaController(ILogger<PizzaController> logger,PizzaRepo PRepo)
        {
            _logger = logger;
            _PRepo = PRepo;
        }
        public IActionResult Index()
        {
            _logger.LogInformation(TempData.Peek("Token").ToString());
            //ViewData["Pizza"] = _PRepo.Get(ID);
            ICollection<PizzaDTO> dTOs=_PRepo.GetAll(TempData.Peek("Token").ToString());
            return View(dTOs) ;
        }
    }
}

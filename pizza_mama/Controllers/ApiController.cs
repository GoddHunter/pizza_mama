using Microsoft.AspNetCore.Mvc;
using pizza_mama.Data;
using pizza_mama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_mama.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        DataContext dataContext;

        public ApiController(DataContext dataContext)
        {
           this.dataContext = dataContext;
        }

        // GET: api/<ApiController>
        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            //var pizza = new Pizza() { name = "pizza test", price = 8, vegetarian = false, ingredients="tomate, oignons, oeuf" };
            var pizzas = dataContext.Pizzas.ToList();

            return Json(pizzas);
        }
    }
}

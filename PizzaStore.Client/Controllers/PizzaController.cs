using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Controllers
{
    public class PizzaController : Controller
    {
        private readonly PizzaStoreDbContext _db;

        public PizzaController(PizzaStoreDbContext dbContext)
        {
            _db = dbContext;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            //ViewData, TemData (dictionaries)
            ViewBag.PizzaList = _db.Pizzas.ToList(); //dynamic object
            //ViewData["PizzaList"] = _db.Pizzas.ToList();
            //TempData["PizzaList"] = _db.Pizzas.ToList();
            return View("Home");

        }
        [HttpGet("{id}")]
        public PizzaModel Get(int id)
        {
            return _db.Pizzas.SingleOrDefault(p => p.Id == id);
            
        }
    }
}
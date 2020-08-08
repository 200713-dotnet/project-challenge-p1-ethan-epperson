using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Client.Models;
using PizzaStore.Domain.Factories;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Controllers
{
    //[Route("/[controller]/[action]")] //can't use this with the global routing
    //[EnableCors("private")]
    public class OrderController : Controller
    {
        private readonly PizzaStoreDbContext _db;

        public OrderController(PizzaStoreDbContext dbContext)
        {
            _db = dbContext;
        }

        public IActionResult Home()
        {
            return View("Order", new PizzaViewModel());
        }

        [HttpPost]
        
        //[ValidateAntiForgeryToken]
        public IActionResult PlaceOrder(PizzaViewModel pizzaViewModel)
        {
            
            if(ModelState.IsValid)
            {
                var p = new PizzaFactory();
                
                //repository.Create(pizzaViewModel);
                return View("~/Views/Pizza/Home2.cshtml");
            }
            else
            {
                return View("Order", pizzaViewModel);
                
            }
            
        }
    }
}
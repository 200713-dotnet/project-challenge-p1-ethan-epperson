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
        private PizzaStoreDbContext _db;

        public OrderController(PizzaStoreDbContext dbContext)
        {
            _db = dbContext;
        }

        public IActionResult Home()
        {
            return View("Order", new PizzaViewModel());
        }

        public IActionResult Special()
        {
            return View("OrderSpecial", new PizzaSpecialViewModel());
        }

        [HttpPost]

        public IActionResult PlaceSpecialty(PizzaSpecialViewModel pizzaSpecialView)
        {
            if(ModelState.IsValid)
            {
                return Redirect("/user/hello");
            }
            else
            {
                return View("OrderSpecial", pizzaSpecialView);
            }
            
          
        }
        //[ValidateAntiForgeryToken]
        public IActionResult PlaceOrder(PizzaViewModel pizzaViewModel)
        {
            
            if(ModelState.IsValid)
            {
                var c = pizzaViewModel.AddCrust();
                var s = pizzaViewModel.AddSize();
                List<ToppingModel> t = pizzaViewModel.AddToppings();
                var p = new PizzaModel();
                p.Crust = c;
                p.Size = s;
                p.Toppings = t;
                return Redirect("/user/hello");
            }
            else
            {
                return View("Order", pizzaViewModel);
                
            }
            
        }

    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaStore.Client.Models;

namespace PizzaStore.Client.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Hello()
        {
            return View("user");
        }

        [HttpPost]
        public IActionResult ReviewOrder()
        {
            return Redirect("/pizza/get");
        }


    }
}
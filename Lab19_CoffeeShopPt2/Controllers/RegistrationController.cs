using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab19_CoffeeShopPt2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab19_CoffeeShopPt2.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new RegisterUser());
        }


        [HttpPost]
        public IActionResult Index(RegisterUser user)
        {
            return RedirectToAction("Summary", user);
        }

        public IActionResult Summary(RegisterUser user)
        {
            if (ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                return View("Index", user);
            }
        }


        
    }
}
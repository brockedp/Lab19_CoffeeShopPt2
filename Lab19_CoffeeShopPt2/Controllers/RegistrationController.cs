﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab19_CoffeeShopPt2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Lab19_CoffeeShopPt2.Controllers
{
    public class RegistrationController : Controller
    {


        


        

        public IActionResult Summary(RegisterUser user)
        {
            if (ModelState.IsValid)
            {

                ViewBag.UserName = user.UserName;
                ViewBag.FirstName = user.FirstName;
                ViewBag.Birthday = user.Birthday;
                ViewBag.Drink = user.Drink;
                ViewBag.Email = user.Email;
                ViewBag.Password = user.Password;
                return View(user);
            }
            else
            {
                return View("Index", user);
            }
        }


        
    }
}
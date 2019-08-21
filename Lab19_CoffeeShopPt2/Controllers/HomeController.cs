using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab19_CoffeeShopPt2.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace Lab19_CoffeeShopPt2.Controllers
{
    public class HomeController : Controller
    {
        List<RegisterUser> registeredUsers = new List<RegisterUser>();
        RegisterUser user = new RegisterUser();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterUser());
        }


        
        [HttpPost]

        public IActionResult AddUser(RegisterUser user)
        {
            if (ModelState.IsValid)
            {
                string registeredUserJson = HttpContext.Session.GetString("RegisteredUserSession");
                if (registeredUserJson != null)
                {
                    // this if statement is retrieving any items that are in the registerd users.
                    registeredUsers = JsonConvert.DeserializeObject<List<RegisterUser>>(registeredUserJson);
                }

                registeredUsers.Add(user);
                HttpContext.Session.SetString("RegisteredUserSession", JsonConvert.SerializeObject(registeredUsers));


                return View("Welcome", user);

            }
            else
            {
                return View("Register", user);
            }

            
        }

        public IActionResult Summary()
        {
            string registeredUserJson = HttpContext.Session.GetString("RegisteredUserSession");
            registeredUsers = JsonConvert.DeserializeObject<List<RegisterUser>>(registeredUserJson);
            return View(registeredUsers);
        }

        public IActionResult LoginUser()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult CheckUser( string UserName, string Password)
        {
            int num = 0;
            foreach (var item in registeredUsers)
            {
                if ((item.UserName == UserName) && (item.Password == Password))
                {
                    string LoginUserJson = HttpContext.Session.GetString("LoginUserSession");
                    user = registeredUsers[num];
                    HttpContext.Session.SetString("LoginUserSession", JsonConvert.SerializeObject(user));
                    break;
                }

                num++;
            }
            return View("UserInfo", user);
            
            

        }
        public IActionResult UserInfo()
        {
            string myUser = HttpContext.Session.GetString("LoginUserSession");
            user = JsonConvert.DeserializeObject<RegisterUser>(myUser);
            return View(user);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

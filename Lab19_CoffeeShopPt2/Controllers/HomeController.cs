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
        RegisterUser loginUser = new RegisterUser();

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


                return RedirectToAction("Welcome", user);

            }
            else
            {
                return RedirectToAction("Register", user);
            }

            
        }
        public IActionResult Welcome(RegisterUser user)
        {
            return View(user);
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
            string registeredUserJson = HttpContext.Session.GetString("RegisteredUserSession");
            registeredUsers = JsonConvert.DeserializeObject<List<RegisterUser>>(registeredUserJson);

            foreach (var item in registeredUsers)
            {
                if ((item.UserName == UserName) && (item.Password == Password))
                {

                    string LoginUserJson = HttpContext.Session.GetString("LoginUserSession");
                    loginUser = item;
                  
                    HttpContext.Session.SetString("LoginUserSession", JsonConvert.SerializeObject(loginUser));
                    
                   
                }
                
            }
            return RedirectToAction("UserInfo");

        }
        public IActionResult UserInfo()
        {
            
            string myUser = HttpContext.Session.GetString("LoginUserSession");
            loginUser = JsonConvert.DeserializeObject<RegisterUser>(myUser);


            return View(loginUser);
            
            
           
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("LoginUserSession");
            return RedirectToAction("Index");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

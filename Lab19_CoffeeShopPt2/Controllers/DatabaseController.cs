using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab19_CoffeeShopPt2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab19_CoffeeShopPt2.Controllers
{
    public class DatabaseController : Controller
    {
        private readonly CoffeeshopDbContext _context;

        public DatabaseController(CoffeeshopDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult MakeNewUser(Member newMember)
        {
            if (ModelState.IsValid)
            {
                _context.Member.Add(newMember);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                return RedirectToAction("Register");
            }
        }
        public IActionResult Shop()
        {
            List<Item> itemList = _context.Item.ToList();
            return View(itemList);
        }
    }
}
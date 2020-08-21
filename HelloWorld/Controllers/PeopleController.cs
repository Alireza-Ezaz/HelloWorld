using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            var users =new List<user>();
            users.Add(new user() { FullName = "Iman rahimi", UserName = "Iman49", PassWord = "12345" });
            users.Add(new user() { FullName = "Ali Karimi", UserName = "Ali@_79", PassWord = "ali12345ali" });
            users.Add(new user() { FullName = "Rahim Sterling", UserName = "Rahim_sosmast", PassWord = "mancity12345" });
            return View(users);
        }

        public IActionResult Details()
        {
            var user = new user
            {
                UserName = "SAlireza78",
                FullName = "S Alireza Ezaz",
                PassWord = "123456"
            };
            return View("Details",user);
        }
    }
}

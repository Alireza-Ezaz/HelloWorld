using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelloWorld.Models;
using Newtonsoft;
using Newtonsoft.Json;
using System.CodeDom.Compiler;
using Microsoft.AspNetCore.Routing;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly LinkGenerator _linkGenerator;
        public HomeController(ILogger<HomeController> logger, LinkGenerator linkGenerator)
        {
            _logger = logger;
            _linkGenerator = linkGenerator;
        }
        public string GetUser()
        {
            var user = new user
            {
                UserName = "SAlireza78",
                FullName = "S Alireza Ezaz",
                PassWord = "123456"
            };
            var json = JsonConvert.SerializeObject(user, Formatting.Indented);
            _logger.LogInformation(json);
            return json;

        }

        public IActionResult Index()
        {
            return View();
        }

        public string TestGen()
        {
            //string path = _linkGenerator.GetPathByAction("Index", "Home");
            var id = "Alireza";
            string path = _linkGenerator.GetPathByAction("Index", "Insta", new { id });
            return path;
        }

        private static user _user = new user() {FullName = "S alireza Ezaz" , UserName = "SAlireza78",PassWord = "12345" };
        //[Route("/privacy")]
        public IActionResult Privacy()
        {
            // throw new Exception("BUG");
            return View(_user);
        }
        [HttpPost]
        public IActionResult Privacy(user user)
        {
            if (ModelState.IsValid)
            {
                _user.FullName = user.FullName;
                _user.PassWord = user.PassWord;
                _user.UserName = user.UserName;
                return RedirectToAction("Privacy");
            }
            
            else
                return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Route("/aboutus/{name?}",Name = "AboutAction")]
        public IActionResult AboutUs(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return View(); 
            }
            else
                return Content($"This is about us page Mr/Miss {name}");

        }
        public IActionResult Link()
        {
            var url = Url.RouteUrl("AboutAction",new { },Request.Scheme);
            return Content(url);
        }

        public IActionResult TestView(int id = 0)
        {
            ViewBag.WebsiteName = "Youtube.com";
            ViewBag.Email = "sar.ezaz@yahoo.com";
            ViewBag.ID = id;
            ViewData["Company"] = "IVS";
            return View();
        }


    }
}

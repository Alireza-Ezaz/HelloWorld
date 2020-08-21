using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class InstaController : Controller
    {
        public string Index(string id)
        {
            return "Page : "+id;
        }
    }
}

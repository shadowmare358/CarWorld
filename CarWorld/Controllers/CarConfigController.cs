using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarWorld.Controllers
{
    public class CarConfigController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

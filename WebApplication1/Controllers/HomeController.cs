﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{ 
    public class HomeController : Controller
    { 
        public IActionResult Index()
        {   
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Info()
        {
            return View();
        }
    }
}
    
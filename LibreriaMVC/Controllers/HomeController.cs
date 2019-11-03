﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LibreriaMVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace LibreriaMVC.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

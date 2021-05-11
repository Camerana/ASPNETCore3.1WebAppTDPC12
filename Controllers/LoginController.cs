using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TDPC12_ASPNETCore3._1WebAppMVC.Models;

namespace TDPC12_ASPNETCore3._1WebAppMVC.Controllers
{
    public class LoginController : Controller
    {
        private TDPC12EFContext _context;

        public LoginController(TDPC12EFContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Test(string firstname, string lastname)
        {
            ViewBag.firstname = firstname;
            ViewBag.lastname = lastname;


            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

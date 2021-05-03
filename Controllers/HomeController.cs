using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using TDPC12_ASPNETCore3._1WebAppMVC.Models;

namespace TDPC12_ASPNETCore3._1WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Persons()
        {
            List<Person> persons = new List<Person>();
            return View(persons);
        }

        public IActionResult PersonByID()
        {
            Person person = new Person();
            return View(person);
        }
        public IActionResult PersonsWithFilter()
        {
            List<Person> persons = new List<Person>();
            return View(persons);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

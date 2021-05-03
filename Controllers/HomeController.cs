using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TDPC12_ASPNETCore3._1WebAppMVC.Models;

namespace TDPC12_ASPNETCore3._1WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private TDPC12EFContext _context;

        public HomeController(TDPC12EFContext context)
        {
            _context = context;
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
            List<Person> persons = _context.Persons.ToList();

            if (!persons.Any())
            {
                var person = new Person()
                {
                    Firstname = "Alessio",
                    Lastname = "Filippucci",
                    //Age = 32
                };

                _context.Persons.Add(person);
                _context.SaveChanges();
            }
            else if (persons.Count == 1 && persons.FirstOrDefault().Age.HasValue && persons.FirstOrDefault().Age.Value == 0)
            {
                var person = persons.FirstOrDefault();

                if (person != null)
                {
                    person.Age = 32;
                    _context.SaveChanges();
                }
            }
            else if (persons.Count == 1 && persons.FirstOrDefault().Age.HasValue && persons.FirstOrDefault().Age.Value == 32)
            {
                var person = persons.FirstOrDefault();
                _context.Persons.Remove(person);
                _context.SaveChanges();
            }

            return View(persons);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

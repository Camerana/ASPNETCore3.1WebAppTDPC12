using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TDPC12_ASPNETCore3._1WebAppMVC.Entity;
using TDPC12_ASPNETCore3._1WebAppMVC.Models;
using TDPC12_ASPNETCore3._1WebAppMVC.Repositories;

namespace TDPC12_ASPNETCore3._1WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private TDPC12Repository _repository;
        public HomeController(TDPC12Repository repository)
        {
            _repository = repository;
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
            List<Person> persons = _repository.GetPersons();
            List<PersonModel> model = new List<PersonModel>();
            foreach (Person p in persons)
                model.Add(new PersonModel()
                {
                    Firstname = p.Firstname,
                    Lastname = p.Lastname
                });
            return View(model);
        }

        public IActionResult PersonByID()
        {
            Person person = _repository.GetPersonByID("04214263-1155-4B46-938A-40D989048BBA");
            PersonModel model = new PersonModel()
            {
                Firstname = person.Firstname,
                Lastname = person.Lastname
            };
            return View(model);
        }
        public IActionResult PersonsWithFilter()
        {
            List<Person> persons = _repository.GetPersonWithFilter("lu");
            List<PersonModel> model = new List<PersonModel>();
            foreach (Person p in persons)
                model.Add(new PersonModel()
                {
                    Firstname = p.Firstname,
                    Lastname = p.Lastname
                });
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

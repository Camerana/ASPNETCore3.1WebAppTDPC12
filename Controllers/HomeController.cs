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
        private TDPC12Repository repository;
        public HomeController(TDPC12Repository repository)
        {
            this.repository = repository;
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
            List<Person> persons = this.repository.GetPersons();
            List<PersonModel> model = new List<PersonModel>();
            foreach (Person p in persons)
                model.Add(new PersonModel()
                {
                    Nome = p.Nome,
                    Cognome = p.Cognome
                });
            return View(model);
        }
        public IActionResult PersonByID()
        {
            Person person = this.repository.GetPersonByID("04214263-1155-4B46-938A-40D989048BBA");
            PersonModel model = new PersonModel()
            {
                Nome = person.Nome,
                Cognome = person.Cognome
            };
            return View(model);
        }
        public IActionResult PersonsWithFilter()
        {
            List<Person> persons = this.repository.GetPersonWithFilter("lu");
            List<PersonModel> model = new List<PersonModel>();
            foreach (Person p in persons)
                model.Add(new PersonModel()
                {
                    Nome = p.Nome,
                    Cognome = p.Cognome
                });
            return View(model);
        }
        public IActionResult InsertPerson()
        {
            Person person = new Person()
            {
                Nome = "Insert Nome",
                Cognome = "Insert Cognome",
                Stipendio = 1000000
            };
            this.repository.InsertPerson(person);
            return View(new PersonModel()
            {
                Nome = person.Nome,
                Cognome = person.Cognome
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

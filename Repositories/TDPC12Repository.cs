using System.Collections.Generic;
using System.Linq;
using TDPC12_ASPNETCore3._1WebAppMVC.Context;
using TDPC12_ASPNETCore3._1WebAppMVC.Entity;

namespace TDPC12_ASPNETCore3._1WebAppMVC.Repositories
{
    public class TDPC12Repository
    {
        private TDPC12DBContext _context;
        public TDPC12Repository(TDPC12DBContext context)
        {
            _context = context;
        }

        public List<Person> GetPersons()
        {
            List<Person> result = _context.Persons.ToList();
            return result;
        }
        public Person GetPersonByID(string id)
        {
            Person result = _context.Persons.Where(p => p.Id.ToString() == id).FirstOrDefault();
            return result;
        }
        public List<Person> GetPersonWithFilter(string filter)
        {
            List<Person> result = _context.Persons
                .Where(p => p.Firstname.Contains(filter)
                || p.Lastname.Contains(filter)).ToList();
            return result;
        }
        public void InsertPerson(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
        }
    }
}
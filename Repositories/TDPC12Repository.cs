using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDPC12_ASPNETCore3._1WebAppMVC.Context;
using TDPC12_ASPNETCore3._1WebAppMVC.Entity;

namespace TDPC12_ASPNETCore3._1WebAppMVC.Repositories
{
    public class TDPC12Repository
    {
        private TDPC12DBContext DBContext;
        public TDPC12Repository(TDPC12DBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public List<Person> GetPersons()
        {
            List<Person> result = this.DBContext.Persons.ToList();
            return result;
        }
        public Person GetPersonByID(string id)
        {
            Person result = this.DBContext.Persons.Where(p => p.ID.ToString() == id).FirstOrDefault();
            return result;
        }
        public List<Person> GetPersonWithFilter(string filter)
        {
            List<Person> result = this.DBContext.Persons
                .Where(p => p.Nome.Contains(filter)
                || p.Cognome.Contains(filter)).ToList();
            return result;
        }
    }
}

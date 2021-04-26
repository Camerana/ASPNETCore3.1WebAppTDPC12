using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TDPC12_ASPNETCore3._1WebAppMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        // GET: api/<APIController>
        /*
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        */

        [HttpGet]
        public async Task<List<string>> GetAsync()
        {
            List<string> result = new List<string>()
            {
                "stringa 1",
                "stringa 2"
            };

            //qui posso mettere await se voglio aspettare
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                result = new List<string>() {
                "stringa async 1",
                "stringa async 2"
                  };
            });
            return result;
        }

        // GET api/<APIController>/5
        [HttpGet("{id}")]
        public async Task<object> GetAsync(int id)
        {
            if (id == 2)
                return BadRequest();
            else
            {
                var item = new
                {
                    ID = id,
                    Nome = "Tizio",
                    Cognome = "Caio"
                };
                return Ok(item);
            }
        }

        // POST api/<APIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<APIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<APIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

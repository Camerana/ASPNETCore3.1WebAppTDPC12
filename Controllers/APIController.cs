﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TDPC12_ASPNETCore3._1WebAppMVC.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TDPC12_ASPNETCore3._1WebAppMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        [HttpGet("getasync")]
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
                //Thread.Sleep(5000);
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
                Person person = new Person()
                {
                    ID = Guid.NewGuid(),
                    Nome = "Tizio",
                    Cognome = "Caio"
                };
                return Ok(person);
            }
        }

        // GET api/<APIController>?nome=valore1&cognome=valore2
        [HttpGet]
        public async Task<object> GetAsync([FromQuery] string nome, [FromQuery] string cognome)
        {
            if (nome != "Tizio")
                return BadRequest();
            else
            {
                Person person = new Person()
                {
                    ID = Guid.NewGuid(),
                    Nome = "Tizio FromQueryString",
                    Cognome = "Caio FromQueryString"
                };
                return Ok(person);
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

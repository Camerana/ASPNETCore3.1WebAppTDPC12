using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDPC12_ASPNETCore3._1WebAppMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomStringsController : ControllerBase
    {
        [HttpGet]
        public async Task<List<char>> GetAsync()
        {
            List<char> stringhe = new List<char>();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
                stringhe.Add(Convert.ToChar(r.Next(0, 20)));
            return stringhe;
        }
    }
}
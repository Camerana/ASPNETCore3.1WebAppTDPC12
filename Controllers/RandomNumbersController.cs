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
    public class RandomNumbersController : ControllerBase
    {
        [HttpGet]
        public async Task<List<int>> GetAsync()
        {
            Random r = new Random();
            List<int> numeri = new List<int>();
            for (int i = 0; i < 10; i++)
                numeri.Add(r.Next());
            return numeri;
        }
    }
}

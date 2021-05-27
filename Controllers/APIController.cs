using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TDPC12_ASPNETCore3._1WebAppMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
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
            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDPC12_ASPNETCore3._1WebAppMVC.Services
{
    public class UserService : IUserService
    {
        public List<string> GetUserFavourites()
        {
            return new List<string>()
            {
                "Queen - Don't stop me now",
                "ACDC - Back in black",
                "Iron Maiden - 2 minutes to midnight"
            };
        }
    }
}

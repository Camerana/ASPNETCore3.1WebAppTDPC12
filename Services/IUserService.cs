using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDPC12_ASPNETCore3._1WebAppMVC.Services
{
    public interface IUserService
    {
        List<string> GetUserFavourites();
    }
}

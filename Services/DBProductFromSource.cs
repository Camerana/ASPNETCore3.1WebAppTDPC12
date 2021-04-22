using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDPC12_ASPNETCore3._1WebAppMVC.Services
{
    public class DBProductFromSource : IProductService
    {
        public List<string> GetProducts()
        {
            return new List<string>()
            {
                "Pesce", "Broccoli", "Pizza"
            };
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TDPC12_ASPNETCore3._1WebAppMVC.Models;
using TDPC12_ASPNETCore3._1WebAppMVC.Services;

namespace TDPC12_ASPNETCore3._1WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private IProductService ProductService;
        private IUserService UserService;

        public HomeController(IProductService productService, IUserService userService)
        {
            this.ProductService = productService;
            this.UserService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Products()
        {
            List<string> prodotti = this.ProductService.GetProducts();
            return View(prodotti);
        }

        public IActionResult UserProfile()
        {
            List<string> canzoni = this.UserService.GetUserFavourites();
            return View(canzoni);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Og_Guild_Bank.Models;
using Og_Guild_Bank.ViewModels;
using RestSharp;

namespace Og_Guild_Bank.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel();
            return View(homeViewModel);
        }
    }
}
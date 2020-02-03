using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Og_Guild_Bank.Models;

namespace Og_Guild_Bank.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult Application()
        {
            Application application = new Application();
            return View(application);
        }
    }
}
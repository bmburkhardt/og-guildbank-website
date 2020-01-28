using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Og_Guild_Bank.Models;

namespace Og_Guild_Bank.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("UpdateItems")]
        public Boolean UpdateItems(string itemsJson)
        {
            Bank bank = null;
            try
            {
                itemsJson = itemsJson.Replace("nil", "-99");
                bank = Newtonsoft.Json.JsonConvert.DeserializeObject<Bank>(itemsJson);
                bank.UpdateBank();
            }
            catch (Exception ex)
            {
                var blah = "";
            }



            return bank.Successful;
        }
    }
}
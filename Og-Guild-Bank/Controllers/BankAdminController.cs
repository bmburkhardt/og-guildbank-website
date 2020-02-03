using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Og_Guild_Bank.Models;

namespace Og_Guild_Bank.Controllers
{
    [Authorize(Roles = "Bank Admin")]
    public class BankAdminController : Controller
    {
        public IActionResult BankManagement()
        {
            return View();
        }

        [Route("/BankAdmin/UpdateItems")]
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

            if (bank == null) return false;
            else return bank.Successful;
        }
    }
}
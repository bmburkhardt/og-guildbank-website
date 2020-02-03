using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Components
{
    public class AdminMenu : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var menuItems = new List<AdminMenuItem> { new AdminMenuItem()
                {
                    ControllerValue = "BankAdmin",
                    DisplayValue = "Bank Management",
                    ActionValue = "BankManagement"
                },
                new AdminMenuItem()
                {
                    ControllerValue = "Admin",
                    DisplayValue = "User management",
                    ActionValue = "UserManagement"
                },
                new AdminMenuItem()
                {
                    ControllerValue = "Admin",
                    DisplayValue = "Role management",
                    ActionValue = "RoleManagement"
                }};

            return View(menuItems);
        }
    }

    public class AdminMenuItem
    {
        public string ControllerValue { get; set; }
        public string DisplayValue { get; set; }
        public string ActionValue { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Og_Guild_Bank.Models;
using Og_Guild_Bank.ViewModels;

namespace Og_Guild_Bank.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemRepository _itemRepository;
        public HomeController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public IActionResult Index()
        {

            var items = _itemRepository.GetAllItems().OrderBy(i => i.Name);
            var homeViewModel = new HomeViewModel()
            {
                Title = "OG Guild Bank",
                Items = items.ToList()
            };
            return View(homeViewModel);
        }
    }
}
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
        private readonly IItemRepository _itemRepository;
        private readonly IContainerRepository _containerRepository;
        private readonly IWalletRepository _walletRepository;
        public HomeController(IItemRepository itemRepository, IContainerRepository containerRepository, IWalletRepository walletRepository)
        {
            _itemRepository = itemRepository;
            _containerRepository = containerRepository;
            _walletRepository = walletRepository;
        }
        public IActionResult Index()
        {
            var items = _itemRepository.GetAllItems().OrderBy(i => i.ContainerId).ThenBy(i => i.BagSlot);
            var containers = _containerRepository.GetAllContainers().OrderBy(c => c.ContainerId);
            var wallet = _walletRepository.GetWallet();
            var homeViewModel = new HomeViewModel()
            {
                Title = "OG Guild Bank",
                Items = items.ToList(),
                Containers = containers.ToList(),
                Wallet = wallet
            };
            homeViewModel.GenerateViewContainers();
            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var item = _itemRepository.GetItemById(id);
            if (item == null)
                return NotFound();

            return View(item);
        }
    }
}
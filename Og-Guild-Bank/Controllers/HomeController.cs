﻿using System;
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
        private readonly IContainerRepository _containerRepository;
        public HomeController(IItemRepository itemRepository, IContainerRepository containerRepository)
        {
            _itemRepository = itemRepository;
            _containerRepository = containerRepository;
        }
        public IActionResult Index()
        {

            var items = _itemRepository.GetAllItems().OrderBy(i => i.Name);
            var containers = _containerRepository.GetAllContainers().OrderBy(c => c.ContainerId);
            var homeViewModel = new HomeViewModel()
            {
                Title = "OG Guild Bank",
                Items = items.ToList(),
                Containers = containers.ToList()
            };
            return View(homeViewModel);
        }
    }
}
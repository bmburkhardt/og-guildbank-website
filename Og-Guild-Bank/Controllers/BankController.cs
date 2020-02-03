using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Og_Guild_Bank.Models;
using Og_Guild_Bank.ViewModels;

namespace Og_Guild_Bank.Controllers
{
    [Authorize(Roles = "Bank Admin,Super Admin,Member")]
    public class BankController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly IContainerRepository _containerRepository;
        private readonly IWalletRepository _walletRepository;
        public BankController(IItemRepository itemRepository, IContainerRepository containerRepository, IWalletRepository walletRepository)
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
            var bankViewModel = new BankViewModel()
            {
                Title = "OG Guild Bank",
                Wallet = wallet
            };
            bankViewModel.GenerateStockedContainers(items.ToList(), containers.ToList());
            return View(bankViewModel);
        }
    }
}
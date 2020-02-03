using Og_Guild_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.ViewModels
{
    public class BankViewModel
    {
        public string Title { get; set; }
        public Wallet Wallet { get; set; }
        public List<StockedBankContainer> ViewContainers { get; set; } = new List<StockedBankContainer>();

        public void GenerateStockedContainers(List<Item> items, List<Container> containers)
        {
            foreach (var container in containers)
            {
                ViewContainers.Add(new StockedBankContainer { ContainerId = container.ContainerId, NumberSlots = container.NumberSlots });
            }
            foreach (var item in items)
            {
                ViewContainers.ElementAt(ViewContainers.FindIndex(c => c.ContainerId == item.ContainerId)).Items.Add(item);
            }
        }
    }
}

using Og_Guild_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Item> Items { get; set; }
        public List<Container> Containers { get; set; }
        public Wallet Wallet { get; set; }
        public List<ViewBankContainer> ViewContainers { get; set; } = new List<ViewBankContainer>();

        public void GenerateViewContainers()
        {
            foreach (var container in Containers)
            {
                ViewContainers.Add(new ViewBankContainer { ContainerId = container.ContainerId, NumberSlots = container.NumberSlots });
            }
            foreach (var item in Items)
            {
                ViewContainers.ElementAt(ViewContainers.FindIndex(c => c.ContainerId == item.ContainerId)).Items.Add(item);
            }
        }
    }
}

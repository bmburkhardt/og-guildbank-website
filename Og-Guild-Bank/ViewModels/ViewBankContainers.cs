using Og_Guild_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.ViewModels
{
    public class ViewBankContainer
    {
        public int ContainerId { get; set; }
        public int NumberSlots { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
    }
}

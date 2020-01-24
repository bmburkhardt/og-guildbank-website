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
    }
}

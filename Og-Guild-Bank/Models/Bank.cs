using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models
{
    public class Bank
    {
        public int Money { get; set; }
        public int Gold { get; set; }
        public int Silver { get; set; }
        public int Copper { get; set; }
        public List<Container> Containers { get; set; }
        public List<Item> Items { get; set; }
    }
}

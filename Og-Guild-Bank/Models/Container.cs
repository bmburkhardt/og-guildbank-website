using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models
{
    public class Container
    {
        public int Id { get; set; }
        public int NumberSlots { get; set; }
        public List<Item> Items { get; set; }
    }
}

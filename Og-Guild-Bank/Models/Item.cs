using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quality { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public int BadId { get; set; }
        public int BagSlotId { get; set; }
        
    }
}

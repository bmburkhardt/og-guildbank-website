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
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public int ItemQuality { get; set; }
        public int ItemQuantity { get; set; }
        public string Image { get; set; }
        public int ContainerId { get; set; }
        public int BagSlot { get; set; }
        
    }
}

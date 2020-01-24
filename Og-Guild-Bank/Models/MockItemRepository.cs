using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models
{
    public class MockItemRepository : IItemRepository
    {
        private List<Item> _items;
        public MockItemRepository()
        {
            if (_items == null)
            {
                InitializeItems();
            }
        }
        private void InitializeItems()
        {
            _items = new List<Item>
            {
                new Item { Id = 13444, Name = "Major Mana Potion", BadId = 2, BagSlotId = 5, Quantity = 5, Quality = 1 },
                new Item { Id = 16846, Name = "Giantstalker's Helmet", BadId = 2, BagSlotId = 4, Quantity = 1, Quality = 4 },
                new Item { Id = 13444, Name = "Major Mana Potion", BadId = -1, BagSlotId = 14, Quantity = 8, Quality = 0 },
                new Item { Id = 0, Name = "", BadId = 1, BagSlotId = 13, Quantity = 0, Quality = 0 },
            };
        }
        public IEnumerable<Item> GetAllItems()
        {
            return _items;
        }

        public Item GetItemById(int itemId)
        {
            return _items.FirstOrDefault(i => i.Id == itemId);
        }
    }
}

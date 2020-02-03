using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _appDbContext;

        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _appDbContext.Items;
        }

        public Item GetItemById(int id)
        {
            return _appDbContext.Items.FirstOrDefault(i => i.Id == id);
        }
    }
}

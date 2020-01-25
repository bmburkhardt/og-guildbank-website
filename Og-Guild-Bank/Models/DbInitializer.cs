using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Items.Any())
            {
                context.AddRange(
                    new Item { ItemCd = 13444, ItemName = "Major Mana Potion", ContainerId = 2, BagSlot = 5, ItemQuantity = 5, ItemQuality = 1 },
                    new Item { ItemCd = 16846, ItemName = "Giantstalker's Helmet", ContainerId = 2, BagSlot = 4, ItemQuantity = 1, ItemQuality = 4 },
                    new Item { ItemCd = 13444, ItemName = "Major Mana Potion", ContainerId = -1, BagSlot = 14, ItemQuantity = 8, ItemQuality = 0 },
                    new Item { ItemCd = 0, ItemName = "", ContainerId = 1, BagSlot = 13, ItemQuantity = 0, ItemQuality = 0 }
                );

                context.SaveChanges();
            }

            if (!context.Containers.Any())
            {
                context.AddRange(
                    new Container { ContainerId = 1, NumberSlots = 16 },
                    new Container { ContainerId = 2, NumberSlots = 14 },
                    new Container { ContainerId = 8, NumberSlots = 12 }
                );

                context.SaveChanges();
            }
        }
    }
}

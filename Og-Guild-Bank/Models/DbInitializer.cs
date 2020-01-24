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
                    new Item { ItemCd = 13444, Name = "Major Mana Potion", BadId = 2, BagSlotId = 5, Quantity = 5, Quality = 1 },
                    new Item { ItemCd = 16846, Name = "Giantstalker's Helmet", BadId = 2, BagSlotId = 4, Quantity = 1, Quality = 4 },
                    new Item { ItemCd = 13444, Name = "Major Mana Potion", BadId = -1, BagSlotId = 14, Quantity = 8, Quality = 0 },
                    new Item { ItemCd = 0, Name = "", BadId = 1, BagSlotId = 13, Quantity = 0, Quality = 0 }
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

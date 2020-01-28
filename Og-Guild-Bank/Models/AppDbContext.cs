using Microsoft.EntityFrameworkCore;
using Og_Guild_Bank.Models.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Container> Containers { get; set; }
        public DbSet<Wallet> Wallet { get; set; }
        public DbSet<ErrorLog> ErrorLog { get; set; }
    }
}

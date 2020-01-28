using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models
{
    public class WalletRepository : IWalletRepository
    {
        private readonly AppDbContext _appDbContext;

        public WalletRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Wallet GetWallet()
        {
            return _appDbContext.Wallet.First();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models
{
    public interface IWalletRepository
    {
        Wallet GetWallet();
    }
}

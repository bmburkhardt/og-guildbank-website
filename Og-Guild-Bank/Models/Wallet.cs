using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models
{
    public class Wallet
    {
        public int Id { get; set; }
        public int TotalCopper { get; set; }
        public int Copper { get; set; }
        public int Silver { get; set; }
        public int Gold { get; set; }

        public void CalculateCoins()
        {
            Gold = TotalCopper / 10000;
            TotalCopper = (TotalCopper - (Gold * 10000));
            Silver = TotalCopper / 100;
            TotalCopper = (TotalCopper - (Silver * 100));
            Copper = TotalCopper;
        }
    }
}

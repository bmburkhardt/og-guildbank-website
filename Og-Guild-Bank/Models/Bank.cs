using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models
{
    public class Bank
    {
        public int Money { get; set; }
        public Wallet Wallet { get; set; }
        public List<Container> Containers { get; set; }
        public List<Item> Items { get; set; }
        public Boolean Successful { get; set; } = false;

        public void UpdateBank()
        {
            
            SqlConnection conn = null;
            SqlCommand command = null;

            try
            {
                // *********************
                // Connect to database
                // *********************
                conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=OgGuildBank;Trusted_Connection=True;MultipleActiveResultSets=true");
                conn.Open();
                command = new SqlCommand(null, conn);
                // *********************

                // *************************
                // Purge current bank data
                // *************************
                command.CommandText = "delete from dbo.containers where id is not null";
                var blah = command.ExecuteNonQuery();
                command.CommandText = "delete from dbo.items where id is not null";
                command.ExecuteNonQuery();
                command.CommandText = "delete from dbo.wallet where id is not null";
                command.ExecuteNonQuery();
                // *************************

                // **************
                // Create Wallet
                // **************
                Wallet = new Wallet { TotalCopper = Money };
                Wallet.CalculateCoins();
                // **************

                // ******************************
                // Get Blizzard API Oauth token
                // ******************************
                BlizzardApi blizzardApi = new BlizzardApi("", "");
                // ******************************

                // *********************
                // Update bank tables
                // *********************

                // Wallet
                command.CommandText = "insert into dbo.wallet(totalcopper,gold,silver,copper) values(@totalcopper,@gold,@silver,@copper)";
                command.Parameters.Add(new SqlParameter("@totalcopper", Money));
                command.Parameters.Add(new SqlParameter("@gold", Wallet.Gold));
                command.Parameters.Add(new SqlParameter("@silver", Wallet.Silver));
                command.Parameters.Add(new SqlParameter("@copper", Wallet.Copper));
                command.ExecuteNonQuery();

                // Containers
                command.CommandText = "insert into dbo.containers(containerid,numberslots) values(@containerid,@numberslots)";
                foreach (var container in Containers)
                {
                    command.Parameters.Clear();
                    command.Parameters.Add(new SqlParameter("@containerid", container.ContainerId));
                    command.Parameters.Add(new SqlParameter("@numberslots", container.NumberSlots));
                    command.ExecuteNonQuery();
                }

                // Items
                command.CommandText = "insert into dbo.items(itemcode,itemname,itemquality,itemquantity,containerid,bagslot,image) values(@itemcode,@itemname,@itemquality,@itemquantity,@containerid,@bagslot,@image)";
                foreach (var item in Items)
                {
                    command.Parameters.Clear();
                    command.Parameters.Add(new SqlParameter("@itemcode", item.ItemCode));
                    command.Parameters.Add(new SqlParameter("@itemname", item.ItemName));
                    command.Parameters.Add(new SqlParameter("@itemquality", item.ItemQuality));
                    command.Parameters.Add(new SqlParameter("@itemquantity", item.ItemQuantity));
                    command.Parameters.Add(new SqlParameter("@containerid", item.ContainerId));
                    command.Parameters.Add(new SqlParameter("@bagslot", item.BagSlot));
                    if (item.ItemCode != -99) command.Parameters.Add(new SqlParameter("@image", blizzardApi.GetItemImage(item.ItemCode)));
                    else command.Parameters.Add(new SqlParameter("@image", "/Media/empty_slot.png"));
                    command.ExecuteNonQuery();
                }
                Debug.WriteLine("done");
                // *********************
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            

            
        }
    }
}

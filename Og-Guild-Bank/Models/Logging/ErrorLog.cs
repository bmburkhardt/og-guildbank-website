using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models.Logging
{
    public class ErrorLog
    {
        public int Id { get; set; }
        public string ErrorMessage { get; set; }
        public string LogTimestamp { get; set; }

        public void InsertToLog(ref SqlConnection conn)
        {
            Boolean newConnectionRequired = false;
            SqlCommand command = null;
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=OgGuildBank;Trusted_Connection=True;MultipleActiveResultSets=true");
                    conn.Open();
                    newConnectionRequired = true;
                }

                command = new SqlCommand(null, conn);
                command.CommandText = "insert into dbo.errorlog(errormessage,logtimestamp) values(@errormessage,current_timestamp)";
                command.Parameters.Add(new SqlParameter("@errormessage", ErrorMessage));
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                if (newConnectionRequired)
                {
                    if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}

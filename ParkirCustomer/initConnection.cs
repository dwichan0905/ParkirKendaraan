using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkirCustomer
{
    class initConnection
    {
        private string serverName;
        private string dbName;

        public initConnection(string server, string dbname)
        {
            this.serverName = server;
            this.dbName = dbname;
        }

        public bool isSQLConnected()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=" + this.serverName + ";Initial Catalog=" + this.dbName + ";Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
        }

        public SqlDataAdapter executeQuery(string querySelect, string tableName)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=" + this.serverName + ";Initial Catalog=" + this.dbName + ";Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = querySelect;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    conn.Close();
                    return da;
                }
                catch (SqlException e)
                {
                    Console.WriteLine("SQL ERROR: " + e.Message);
                    return null;
                }
            }
        }

        public void executeUpdate(string query)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=" + this.serverName + ";Initial Catalog=" + this.dbName + ";Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("SQL ERROR: " + e.Message);
                }
            }
        }
    }
}

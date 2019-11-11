using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CoffeManagement
{
    public class DatabaseAccess
    {
        public SqlConnection conn = null;
        string sqlconn = @"Server=OANHNGUYEN-PC\THANHCHINGUYENPK;Database=COFFEEMANAGEMENT;User Id=thanhchinguyenpk;pwd=1";

        public void OpenConnection()
        {

            if (conn == null)
            {
                conn = new SqlConnection(sqlconn);

            }

            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}

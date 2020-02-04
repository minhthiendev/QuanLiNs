using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
    class DataConnection
    {
        string sql;
        public DataConnection()
        {
            sql = "Data Source = DESKTOP-K5M2MAE\\SQLEXPRESS ; Initial Catalog = EMS;UID=sa;PWD=123;";
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(sql);
        }
    }
}

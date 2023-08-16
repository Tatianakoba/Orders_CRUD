using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class DB
    {
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-SFOQ0JO\SQLEXPRESS;Initial catalog=Orders;Integrated Security=True");

        public void openConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Closed)
                sqlconnection.Open();
        }
        public void closeConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Open)
                sqlconnection.Close();
        }
        public SqlConnection getConnection() 
        { 
            return sqlconnection; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    class DbConnectionClass
    {
        public SqlConnection connectToDatabase()
        {
            string conString = Properties.Settings.Default.stock_marketConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conString);
            return sqlConnection;
        }
    }
}

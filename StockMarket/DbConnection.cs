using System.Data.SqlClient;

namespace StockMarket
{
    class DbConnection
    {
        public SqlConnection connectToDatabase()
        {
            string conString = Properties.Settings.Default.stock_marketConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conString);
            return sqlConnection;
        }
    }
}

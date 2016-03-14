using System.Data.SqlClient;

namespace StockMarket
{
    class DbConnection
    {
        // declare variables
        private string conString;
        private SqlConnection connect;

        // create constructor
        public DbConnection()
        {
            connectDatabase();
        }

        public SqlConnection connectDatabase()
        {
            conString = Properties.Settings.Default.stock_marketConnectionString;
            connect = new SqlConnection(conString);
            return connect;
        }

        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = connectDatabase(); }
        }
    }
}

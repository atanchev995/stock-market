using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockMarket
{
    class StockQuote
    {
        // connect to database
        static DbConnection con = new DbConnection();
        SqlConnection sqlConnection = con.connectToDatabase();

        /**
         * Enters data into the listview
         */
        public void fillList(ListView listQuote, SqlDataAdapter dataAdapterQuote)
        {
            // create DataTable and fill it
            DataTable dataTable = new DataTable();
            dataAdapterQuote.Fill(dataTable);

            // use a for loop to populate the list view with data
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dataRow["symbol"].ToString());
                listItem.SubItems.Add(dataRow["company"].ToString());
                listItem.SubItems.Add(dataRow["price"].ToString());
                listQuote.Items.Add(listItem);
            }

            // add columns to the list view
            listQuote.View = View.Details;
            listQuote.Columns.Add("Symbol");
            listQuote.Columns.Add("Company");
            listQuote.Columns.Add("Price");

            // set the column width to auto resize
            listQuote.Columns[0].Width = -1;
            listQuote.Columns[1].Width = -1;
            listQuote.Columns[2].Width = -1;
        }

        /**
         * Fills the ListView on the Quote tab with data
         */
        public void fillQuote(ListView listQuote)
        {
            try
            {
                // create SqlDataAdapter with Sql command
                sqlConnection.Open();
                SqlDataAdapter dataAdapterQuote = new SqlDataAdapter("select * from quote order by company", sqlConnection);

                // fill the quote list with data
                fillList(listQuote, dataAdapterQuote);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /**
         * Searches the quote list
         */
        public void searchQuote(string searchString, ListView listQuote)
        {
            try
            {
                // create SqlDataAdapter with Sql command
                sqlConnection.Open();
                SqlDataAdapter dataAdapterQuote = new SqlDataAdapter("select * from quote where concat(symbol, ' ', company) like '%" + searchString + "%' order by company", sqlConnection);

                // clear previous items in list view
                listQuote.Columns.Clear();
                listQuote.Items.Clear();

                // fill the quote list with search results
                fillList(listQuote, dataAdapterQuote);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}

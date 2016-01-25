using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket
{
    class PortfolioClass
    {
        // connect to database
        static DbConnectionClass con = new DbConnectionClass();
        SqlConnection sqlConnection = con.connectToDatabase();

        /**
         * Enters data into the listview
         */
        public void fillList(ListView listPortfolio, SqlDataAdapter dataAdapterPortfolio)
        {
            // create DataTable and fill it
            DataTable dataTable = new DataTable();
            dataAdapterPortfolio.Fill(dataTable);

            // use a for loop to populate the list view with data
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dataRow["symbol"].ToString());
                listItem.SubItems.Add(dataRow["company"].ToString());
                listItem.SubItems.Add(dataRow["shares"].ToString());
                listItem.SubItems.Add(dataRow["price"].ToString());
                listItem.SubItems.Add(dataRow["total"].ToString());
                listPortfolio.Items.Add(listItem);
            }

            // add columns to the list view
            listPortfolio.View = View.Details;
            listPortfolio.Columns.Add("Symbol");
            listPortfolio.Columns.Add("Company");
            listPortfolio.Columns.Add("Shares");
            listPortfolio.Columns.Add("Price");
            listPortfolio.Columns.Add("Total");

            // set the column width to auto resize
            listPortfolio.Columns[0].Width = -1;
            listPortfolio.Columns[1].Width = -1;
            listPortfolio.Columns[2].Width = -2;
            listPortfolio.Columns[3].Width = -1;
            listPortfolio.Columns[4].Width = -1;
        }

        /**
         * Fills the ListView on the Portfolio tab with data
         */
        public void fillPortfolio(ListView listPortfolio)
        {
            try
            {
                // create SqlDataAdapter with Sql command
                sqlConnection.Open();
                SqlDataAdapter dataAdapterPortfolio = new SqlDataAdapter("select * from portfolio order by company", sqlConnection);

                // fill the portfolio list with data
                fillList(listPortfolio, dataAdapterPortfolio);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /**
         * Searches the portfolio list
         */
        public void searchPortfolio(string searchString, ListView listPortfolio)
        {
            try
            {
                // create SqlDataAdapter with Sql command
                sqlConnection.Open();
                SqlDataAdapter dataAdapterPortfolio = new SqlDataAdapter("select * from portfolio where concat(symbol, ' ', company) like '%" + searchString + "%' order by company", sqlConnection);

                // clear previous items in list view
                listPortfolio.Columns.Clear();
                listPortfolio.Items.Clear();

                // fill the quote list with search results
                fillList(listPortfolio, dataAdapterPortfolio);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /**
         * Returns the shares of the company
         */
        public string getShares(string selectedCompany)
        {
            try
            {
                // create sql command to select the shares of the company
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("select shares from portfolio where company like '" + selectedCompany + "'"), sqlConnection);

                // use an SqlDataReader to get the shares of the company
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    // return the shares of the company
                    if (dataReader.Read())
                        return dataReader["shares"].ToString();
                }
            }
            finally
            {
                sqlConnection.Close();
            }

            // if there's an error return not found
            return "Not Found";
        }
    }
}

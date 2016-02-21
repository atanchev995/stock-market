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
    class HistoryClass
    {
        // connect to database
        static DbConnection con = new DbConnection();
        SqlConnection sqlConnection = con.connectToDatabase();

        /**
         * Enters data into the listview
         */
        public void fillList(ListView listHistory, SqlDataAdapter dataAdapterHistory)
        {
            // create DataTable and fill it
            DataTable dataTable = new DataTable();
            dataAdapterHistory.Fill(dataTable);

            // use a for loop to populate the list view with data
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dataRow["transaction"].ToString());
                listItem.SubItems.Add(dataRow["time"].ToString());
                listItem.SubItems.Add(dataRow["symbol"].ToString());
                listItem.SubItems.Add(dataRow["company"].ToString());
                listItem.SubItems.Add(dataRow["shares"].ToString());
                listItem.SubItems.Add(dataRow["price"].ToString());
                listHistory.Items.Add(listItem);
            }

            // add columns to the list view
            listHistory.View = View.Details;
            listHistory.Columns.Add("Transaction");
            listHistory.Columns.Add("Time");
            listHistory.Columns.Add("Symbol");
            listHistory.Columns.Add("Company");
            listHistory.Columns.Add("Shares");
            listHistory.Columns.Add("Price");

            // set the column width to auto resize
            listHistory.Columns[0].Width = -2;
            listHistory.Columns[1].Width = -1;
            listHistory.Columns[2].Width = -1;
            listHistory.Columns[3].Width = -1;
            listHistory.Columns[4].Width = -2;
            listHistory.Columns[5].Width = -1;
        }

        /**
         * Fills the ListView on the Portfolio tab with data
         */
        public void fillHistory(ListView listHistory)
        {
            try
            {
                // create SqlDataAdapter with Sql command
                sqlConnection.Open();
                SqlDataAdapter dataAdapterHistory = new SqlDataAdapter("select * from history reverse order by time desc", sqlConnection);

                // fill the portfolio list with data
                fillList(listHistory, dataAdapterHistory);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}

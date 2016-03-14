using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockMarket
{
    class SellStocks
    {
        // connect to database
        static DbConnection con = new DbConnection();
        SqlConnection sqlConnection = con.connectToDatabase();

        /**
         * Fills the sell combobox with the companies
         */
        public void fillSellComboBox(ComboBox cmbSell)
        {
            try
            {
                // create sql command to select the companies
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("select company from portfolio order by company", sqlConnection);

                // use an SqlDataReader to get the companies
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    // add the companies to the combobox
                    while (dataReader.Read())
                        cmbSell.Items.Add(dataReader["company"].ToString());
                }
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /**
         * Returns the price of a company's stock
         */
        public string getPrice(string selectedCompany)
        {
            try
            {
                // create sql command to select the price of a company's stock
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("select price from portfolio where company like '" + selectedCompany + "'"), sqlConnection);

                // use an SqlDataReader to get the name of the user
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    // return the name of the user
                    if (dataReader.Read())
                        return dataReader["price"].ToString();
                }
            }
            finally
            {
                sqlConnection.Close();
            }

            // if there's an error return not found
            return "Not Found";
        }

        /**
         * Returns the symbol of the company
         */
        public string getSymbol(string selectedCompany)
        {
            try
            {
                // create sql command to select the symbol of the company
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("select symbol from portfolio where company like '" + selectedCompany + "'"), sqlConnection);

                // use an SqlDataReader to get the symbol of the company
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    // return the symbol of the company
                    if (dataReader.Read())
                        return dataReader["symbol"].ToString();
                }
            }
            finally
            {
                sqlConnection.Close();
            }

            // if there's an error return not found
            return "Not Found";
        }

        /**
         * Returns the id of the company
         */
        public string getId(string selectedCompany)
        {
            try
            {
                // create sql command to select the id of the company
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("select Id from portfolio where company like '" + selectedCompany + "'"), sqlConnection);

                // use an SqlDataReader to get the id of the company
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    // return the id of the company
                    if (dataReader.Read())
                        return dataReader["Id"].ToString();
                }
            }
            finally
            {
                sqlConnection.Close();
            }

            // if there's an error return not found
            return "Not Found";
        }

        /**
         * Calculates the total cost based on the amount of shares sold
         */
        public string calculateCost(string amountOfShares, string priceOfShares, string costOfShares, string selectedCompany)
        {
            // check if the value is a number, if the company or the amount is empty
            int parsedValue;
            if (int.TryParse(amountOfShares, out parsedValue) && !String.IsNullOrEmpty(selectedCompany) && !String.IsNullOrWhiteSpace(amountOfShares))
            {
                // calculate the amount
                double priceValue = Convert.ToDouble(priceOfShares);
                double amountValue = Convert.ToDouble(amountOfShares);
                double costValue = priceValue * amountValue;
                costOfShares = Convert.ToString(costValue);
            }
            // if it is then clear it
            else if (String.IsNullOrWhiteSpace(amountOfShares))
            {
                costOfShares = String.Empty;
            }

            return costOfShares;
        }

        /**
         * Sells a number of stocks, adds the transaction to portfolio and history, and updates the user's money
         */
        public void sellShares(ComboBox cmbSell, string idOfCompany, string amountOfShares, string costOfShares, string symbolOfCompany, string nameOfCompany, string priceOfShare)
        {
            // check if the user has selected a stock
            int parsedValue;
            if (String.IsNullOrEmpty(cmbSell.Text))
            {
                MessageBox.Show("You must specify a stock to sell.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // check if user has entered an amount of shares
            else if (String.IsNullOrWhiteSpace(amountOfShares))
            {
                MessageBox.Show("You must specify an amount of shares.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // make sure that user buys whole shares, not fractions
            else if (!int.TryParse(amountOfShares, out parsedValue))
            {
                MessageBox.Show("Invalid number of shares.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // check how much shares user has
                UserPortfolio checkShares = new UserPortfolio();
                double userShares = Convert.ToDouble(checkShares.getShares(nameOfCompany));

                // convert variables
                int id = Convert.ToInt32(idOfCompany);
                int shares = Convert.ToInt32(amountOfShares);
                NumberFormat format = new NumberFormat();
                double price = Convert.ToDouble(priceOfShare);
                string priceString = format.ToUSString(price);
                double total = Convert.ToDouble(costOfShares);
                string totalString = format.ToUSString(total);

                // check if the user wants to sell more than he has
                if (userShares < shares)
                {
                    MessageBox.Show("You have less than the amount of shares you want to sell.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        // remove stock from the portfolio
                        sqlConnection.Open();
                        SqlCommand sqlCommandSell = new SqlCommand(String.Format("update portfolio set shares = shares - {3}, total = total - {5} where id = {0} if ((select shares from portfolio where Id = {0}) <= {3}) delete from portfolio where id = {0}", id, symbolOfCompany, nameOfCompany, shares, priceString, totalString), sqlConnection);
                        sqlCommandSell.ExecuteNonQuery();

                        // add selling stock to history
                        SqlCommand sqlCommandHistory = new SqlCommand(String.Format("insert into history values ({0}, 'SELL', CURRENT_TIMESTAMP, '{1}', '{2}', {3}, {4})", id, symbolOfCompany, nameOfCompany, shares, priceString), sqlConnection);
                        sqlCommandHistory.ExecuteNonQuery();

                        // update money
                        SqlCommand sqlCommandMoney = new SqlCommand(String.Format("update account set money = money + {0}", totalString), sqlConnection);
                        sqlCommandMoney.ExecuteNonQuery();

                        // inform the user about the sucessfull transaction
                        MessageBox.Show(String.Format("You successfully sold {0} shares from {1}. The total cost was {2}.", shares, nameOfCompany, total), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }
    }
}

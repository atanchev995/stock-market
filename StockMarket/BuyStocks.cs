using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockMarket
{
    class BuyStocks
    {
        // declare variables
        private string price;
        private string symbol;
        private string id;

        // connect to database
        static DbConnection con = new DbConnection();
        SqlConnection sqlConnection = con.connectToDatabase();

        /**
         * Fills the buy combobox with the companies
         */
        public void fillBuyComboBox(ComboBox cmbBuy)
        {
            try
            {
                // create sql command to select the companies
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("select company from quote order by company", sqlConnection);

                // use an SqlDataReader to get the companies
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    // add the companies to the combobox
                    while (dataReader.Read())
                        cmbBuy.Items.Add(dataReader["company"].ToString());     
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
                SqlCommand sqlCommand = new SqlCommand(String.Format("select price from quote where company like '" + selectedCompany + "'"), sqlConnection);

                // use an SqlDataReader to get the name of the user
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    // return the name of the user
                    if (dataReader.Read())
                        price = dataReader["price"].ToString();
                }
            }
            finally
            {
                sqlConnection.Close();
            }

            // return price
            return price;
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
                SqlCommand sqlCommand = new SqlCommand(String.Format("select symbol from quote where company like '" + selectedCompany + "'"), sqlConnection);

                // use an SqlDataReader to get the symbol of the company
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    // return the symbol of the company
                    if (dataReader.Read())
                        symbol = dataReader["symbol"].ToString();
                }
            }
            finally
            {
                sqlConnection.Close();
            }

            // return symbol
            return symbol;
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
                SqlCommand sqlCommand = new SqlCommand(String.Format("select Id from quote where company like '" + selectedCompany + "'"), sqlConnection);

                // use an SqlDataReader to get the id of the company
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    // return the id of the company
                    if (dataReader.Read())
                        id = dataReader["Id"].ToString();   
                }
            }
            finally
            {
                sqlConnection.Close();
            }

            // return id
            return id;
        }

        /**
         * Calculates the total cost based on the amount of shares bought
         */
        public void calculateCost(TextBox amountOfShares, TextBox priceOfShares, TextBox costOfShares, ComboBox cmbBuy)
        {
            // check if the value is a number, if the company or the amount is empty
            int parsedValue;
            if (int.TryParse(amountOfShares.Text, out parsedValue) && !String.IsNullOrEmpty(cmbBuy.Text) && !String.IsNullOrWhiteSpace(amountOfShares.Text))
            {
                // calculate the amount
                double priceValue = Convert.ToDouble(priceOfShares.Text);
                double amountValue = Convert.ToDouble(amountOfShares.Text);
                double costValue = priceValue * amountValue;
                costOfShares.Text = Convert.ToString(costValue);
            }
            // if it is then clear it
            else if (String.IsNullOrWhiteSpace(amountOfShares.Text))
            {
                amountOfShares.Text = String.Empty;
            }
        }

        /**
         * Sells a number of stocks, adds the transaction to portfolio and history, and updates the user's money
         */
        public void buyShares(ComboBox cmbBuy, string idOfCompany, TextBox amountOfShares, TextBox costOfShares, string symbolOfCompany, string nameOfCompany, string priceOfShare)
        {
            // check if the user has selected a stock
            int parsedValue;
            if (String.IsNullOrEmpty(cmbBuy.Text))
            {
                MessageBox.Show("You must specify a stock to buy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // check if user has entered an amount of shares
            else if (String.IsNullOrWhiteSpace(amountOfShares.Text))
            {
                MessageBox.Show("You must specify an amount of shares.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // make sure that user buys whole shares, not fractions
            else if (!int.TryParse(amountOfShares.Text, out parsedValue))
            {
                MessageBox.Show("Invalid number of shares.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // check how much money user has
                AccountManagement checkMoney = new AccountManagement();
                double totalMoney = Convert.ToDouble(checkMoney.Money);
                double totalCost = Convert.ToDouble(costOfShares.Text);

                // check if the user can afford to buy this stock
                if (totalMoney < totalCost)
                {
                    MessageBox.Show("You can't afford that.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // convert variables
                    int id = Convert.ToInt32(idOfCompany);
                    int shares = Convert.ToInt32(amountOfShares.Text);
                    NumberFormat format = new NumberFormat();
                    double price = Convert.ToDouble(priceOfShare);
                    string priceString = format.ToUSString(price);
                    double total = Convert.ToDouble(costOfShares.Text);
                    string totalString = format.ToUSString(total);

                    try
                    {
                        // add stock to the portfolio
                        sqlConnection.Open();
                        SqlCommand sqlCommandBuy = new SqlCommand(String.Format("update portfolio set shares = shares + {3}, total = total + {5} where id = {0} if @@rowcount=0 insert into portfolio values ({0}, '{1}', '{2}', {3}, {4}, {5})", id, symbolOfCompany, nameOfCompany, shares, priceString, totalString), sqlConnection);
                        sqlCommandBuy.ExecuteNonQuery();

                        // add buying stock to history
                        SqlCommand sqlCommandHistory = new SqlCommand(String.Format("insert into history values ({0}, 'BUY', CURRENT_TIMESTAMP, '{1}', '{2}', {3}, {4})", id, symbolOfCompany, nameOfCompany, shares, priceString), sqlConnection);
                        sqlCommandHistory.ExecuteNonQuery();

                        // update money
                        SqlCommand sqlCommandMoney = new SqlCommand(String.Format("update account set money = money - {0}", totalString), sqlConnection);
                        sqlCommandMoney.ExecuteNonQuery();
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

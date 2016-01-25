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
    class AccountClass
    {
        // connect to database
        static DbConnectionClass con = new DbConnectionClass();
        SqlConnection sqlConnection = con.connectToDatabase();

        /**
         * Creates account by using an Sql command
         */
        public void createAccount(string username, string name, string surname, int money)
        {
            // create Sql command to insert account data into the account table and execute it
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("insert into account values ('{0}', '{1}', '{2}', '{3}')", username, name, surname, money), sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /**
         * Checks if an account exists
         */
        public int checkAccount()
        {
            try
            {
                // create sql command to select all data from account table
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("select * from account"), sqlConnection);
                SqlDataReader queryCommandReader = sqlCommand.ExecuteReader();

                // create DataTable and fill it
                DataTable dataTable = new DataTable();
                dataTable.Load(queryCommandReader);

                // count the number of rows in the account table
                int rowCount = dataTable.Rows.Count;

                // return the number of rows in the account table
                return rowCount;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /**
         * Returns the Id of the user
         */
        public string getId()
        {
            try
            {
                // create sql command to select the Id of the user
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("select Id from account"), sqlConnection);

                // use an SqlDataReader to get the Id of the user
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    // return the Id of the user
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
         * Enables the user to save the edits made to their account
         */
        public void editAccount(string Id, string newUsername, string newName, string newSurname, double newMoney)
        {
            // check if the user has entered all fields
            double parsedValue;
            string money = newMoney.ToString();
            if (String.IsNullOrWhiteSpace(newUsername) || String.IsNullOrWhiteSpace(newName) || String.IsNullOrWhiteSpace(newSurname) || String.IsNullOrWhiteSpace(money))
            {
                MessageBox.Show("You can't leave an empty field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // make sure that money is a number
            else if (!double.TryParse(money, out parsedValue))
            {
                MessageBox.Show("Invalid amount of money.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // convert variables
                    NumberFormatClass format = new NumberFormatClass();
                    string newMoneyString = format.ToUSString(newMoney);

                    // insert new data
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(String.Format("update account set username = '{0}', name = '{1}', surname = '{2}', money = {3} where Id = {4}", newUsername, newName, newSurname, newMoneyString, Id), sqlConnection);
                    sqlCommand.ExecuteNonQuery();

                    // inform the user about the sucessfull transaction
                    MessageBox.Show("You successfully edited your account.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        /**
         * Returns the username of the user
         */
        public string getUsername()
        {
            // create sql command to select the username of the user
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("select username from account"), sqlConnection);

                // use an SqlDataReader to get the username of the user
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    // return the name of the user
                    if (dataReader.Read())
                        return dataReader["username"].ToString();   
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
         * Returns the name of the user
         */
        public string getName()
        {
            try
            {
                // create sql command to select the name of the user
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("select name from account"), sqlConnection);

                // use an SqlDataReader to get the name of the user
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    // return the name of the user
                    if (dataReader.Read())
                        return dataReader["name"].ToString();
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
         * Returns the surname of the user
         */
        public string getSurname()
        {
            try
            {
                // create sql command to select the surname of the user
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("select surname from account"), sqlConnection);

                // use an SqlDataReader to get the surname of the user
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    // return the name of the user
                    if (dataReader.Read())
                        return dataReader["surname"].ToString();      
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
         * Returns the amount of money of the user
         */
        public string getMoney()
        {
            try
            {
                // create sql command to select the amount of money of the user
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("select money from account"), sqlConnection);

                // use an SqlDataReader to get the amount of money of the user
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    // return the amount of money of the user
                    if (dataReader.Read())
                        return dataReader["money"].ToString();     
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

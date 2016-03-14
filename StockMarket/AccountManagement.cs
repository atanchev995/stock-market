using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockMarket
{
    class AccountManagement
    {
        // declare variables
        private int accountExists;
        private string id;
        private string username;
        private string name;
        private string surname;
        private string money;

        // create constructor
        public AccountManagement()
        {
            checkAccountExists();
            checkId();
            checkUsername();
            checkName();
            checkSurname();
            checkMoney();
        }

        // connect to database
        static DbConnection con = new DbConnection();
        SqlConnection sqlConnection = con.Connect;

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
        public int checkAccountExists()
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
                accountExists = dataTable.Rows.Count;

                return accountExists;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public int AccountExists
        {
            get { return accountExists; }
            set { accountExists = checkAccountExists(); }
        }

        /**
         * Returns the Id of the user
         */
        public string checkId()
        {
            try
            {
                // create sql command to select the Id of the user
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("select Id from account"), sqlConnection);

                // use an SqlDataReader to get the Id of the user
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    // get the Id of the user
                    if (dataReader.Read())
                    {
                        id = dataReader["Id"].ToString();
                    }
                }
            }
            finally
            {
                sqlConnection.Close();
            }

            // return the id
            return id;
        }

        public string Id
        {
            get { return id; }
            set { id = checkId(); }
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
                    NumberFormat format = new NumberFormat();
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
        public string checkUsername()
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
                        username = dataReader["username"].ToString();   
                }
            }
            finally
            {
                sqlConnection.Close();
            }

            // if there's an error return not found
            return username;
        }

        public string Username
        {
            get { return username; }
            set { username = checkUsername(); }
        }

        /**
         * Returns the name of the user
         */
        public string checkName()
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
                        name = dataReader["name"].ToString();
                }
            }
            finally
            {
                sqlConnection.Close();
            }

            // if there's an error return not found
            return name;
        }

        public string Name
        {
            get { return name; }
            set { name = checkName(); }
        }

        /**
         * Returns the surname of the user
         */
        public string checkSurname()
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
                        surname = dataReader["surname"].ToString();      
                }
            }
            finally
            {
                sqlConnection.Close();
            }

            // return surname
            return surname;
        }

        public string Surname
        {
            get { return surname; }
            set { surname = checkSurname(); }
        }

        /**
         * Returns the amount of money of the user
         */
        public string checkMoney()
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
                    {
                        money = dataReader["money"].ToString();
                    }  
                }
            }
            finally
            {
                sqlConnection.Close();
            }

            // return money
            return money;
        }

        public string Money
        {
            get { return money; }
            set { money = checkMoney(); }
        }
    }
}

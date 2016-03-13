using System;
using System.Windows.Forms;

namespace StockMarket
{
    public partial class frmCreateAccount : Form
    {
        AccountManagement create = new AccountManagement();

        public frmCreateAccount()
        {
            InitializeComponent();
        }

        /**
         * Creates account for the user
         */
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // store the user information in variables
            string username = txtUsername.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            int money = Convert.ToInt32(txtMoney.Text);

            // call function to create the account
            create.createAccount(username, name, surname, money);

            // hide the create account form
            this.Hide();

            // show the stock market form
            frmStockMarket market = new frmStockMarket();
            market.Show();
        }
    }
}

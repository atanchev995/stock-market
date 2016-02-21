using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket
{
    public partial class frmCreateAccount : Form
    {
        AccountClass create = new AccountClass();

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

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
    public partial class frmAccount : Form
    {
        AccountClass account = new AccountClass();

        private readonly frmStockMarket _frmStockMarket;
        public frmAccount(frmStockMarket frmStockMarket)
        {
            InitializeComponent();
            _frmStockMarket = frmStockMarket;
        }

        frmStockMarket stock = new frmStockMarket();

        /**
         * Fills the account form with information
         */
        private void frmAccount_Load(object sender, EventArgs e)
        {
            
            string username = account.getUsername();
            string name = account.getName();
            string surname = account.getSurname();
            string money = account.getMoney();

            txtUsername.Text = username;
            txtName.Text = name;
            txtSurname.Text = surname;
            txtMoney.Text = money;
        }

        /**
         * Enables the user to edit their account
         */
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtUsername.ReadOnly = false;
            txtName.ReadOnly = false;
            txtSurname.ReadOnly = false;
            txtMoney.ReadOnly = false;

            btnEdit.Visible = false;
            btnSave.Visible = true;
        }

        /**
         * Enables the user to save the edits made to their account
         */
        private void btnSave_Click(object sender, EventArgs e)
        {
            txtUsername.ReadOnly = true;
            txtName.ReadOnly = true;
            txtSurname.ReadOnly = true;
            txtMoney.ReadOnly = true;
            
            string Id = account.getId();
            string newUsername = txtUsername.Text;
            string newName = txtName.Text;
            string newSurname = txtSurname.Text;
            double newMoney = Convert.ToDouble(txtMoney.Text);
            account.editAccount(Id, newUsername, newName, newSurname, newMoney);

            _frmStockMarket.fillName();
            _frmStockMarket.fillMoney();

            btnEdit.Visible = true;
            btnSave.Visible = false;
        }
    }
}

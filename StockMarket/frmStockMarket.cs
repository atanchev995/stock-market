using System;
using System.Windows.Forms;

namespace StockMarket
{
    public partial class frmStockMarket : Form
    {
        UserPortfolio portfolio = new UserPortfolio();
        StockQuote quote = new StockQuote();
        BuyStocks buy = new BuyStocks();
        SellStocks sell = new SellStocks();
        StocksHistory history = new StocksHistory();

        public frmStockMarket()
        {
            InitializeComponent();
        }

        /**
         * Gets the name of the user and put it on a label
         */
        public void fillName()
        {
            AccountManagement account = new AccountManagement();
            string nameOfUser = account.Name;
            lblWelcome.Text = "Welcome: " + nameOfUser;
        }

        /**
         * Gets the amount of money of the user and put it on a label
         */
        public void fillMoney()
        {
            AccountManagement account = new AccountManagement();
            string moneyOfUser = account.Money;
            lblMoney.Text = "Money: " + moneyOfUser;
        }

        /**
         * Fills the quote ListView
         */
        public void fillPortfolio()
        {
            portfolio.fillPortfolio(listPortfolio);
        }

        /**
         * Fills the quote ListView
         */
        public void fillQuote()
        {
            quote.fillQuote(listQuote);
        }

        /**
         * Fills the buy ComboBox
         */
        public void fillBuyComboBox()
        {
            buy.fillBuyComboBox(cmbBuy);
        }

        /**
         * Fills the sell ComboBox
         */
        public void fillSellComboBox()
        {
            sell.fillSellComboBox(cmbSell);
        }

        /**
         * Fills the history ListView
         */
        public void fillHistory()
        {
            history.fillHistory(listHistory);
        }

        /**
         * Fills the form with information on load
         */
        private void frmStockMarket_Load(object sender, EventArgs e)
        {
            fillName();
            fillMoney();
            fillPortfolio();
            fillQuote();
            fillBuyComboBox();
            fillSellComboBox();
            fillHistory();
        }

        /**
         * Confirms quit
         */
        private void frmStockMarket_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to quit the application?", "Stock Market", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /**
         * Searches the quote database
         */
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearchQuote.Text;
            quote.searchQuote(searchString, listQuote);
        }

        /**
         * Searches the portfolio
         */
        private void btnSearchPortfolio_Click(object sender, EventArgs e)
        {
            string searchString = txtSearchPortfolio.Text;
            portfolio.searchPortfolio(searchString, listPortfolio);
        }

        string priceSelectedBuy { get; set; }
        string priceSelectedSell { get; set; }

        /**
         * Fills the buy combobox with the names of companies
         */
        private void cmbBuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCompany = cmbBuy.SelectedItem.ToString();
            priceSelectedBuy = buy.getPrice(selectedCompany);
            txtPriceBuy.Text = priceSelectedBuy;
            txtAmountBuy.Text = string.Empty;
            txtCostBuy.Text = string.Empty;
        }

        /**
         * Shows the amount of cost
         */
        private void txtAmountBuy_TextChanged(object sender, EventArgs e)
        {
            buy.calculateCost(txtAmountBuy, txtPriceBuy, txtCostBuy, cmbBuy);
        }

        /**
         * Buys a number of stocks
         */
        private void btnBuy_Click(object sender, EventArgs e)
        {
            string selectedCompany = cmbBuy.SelectedItem.ToString();
            string symbolOfCompany = buy.getSymbol(selectedCompany);
            string idOfCompany = buy.getId(selectedCompany);
            buy.buyShares(cmbBuy, idOfCompany, txtAmountBuy, txtCostBuy, symbolOfCompany, selectedCompany, priceSelectedBuy);

            // update the money label
            fillMoney();

            // clear previous items in portfolio
            listPortfolio.Columns.Clear();
            listPortfolio.Items.Clear();

            // update the portfolio
            fillPortfolio();

            // clear previous items in sell combobox
            cmbSell.Items.Clear();

            // update sell combobox
            fillSellComboBox();

            // clear previous items in history
            listHistory.Columns.Clear();
            listHistory.Items.Clear();

            // update the history
            fillHistory();

            // inform the user about the sucessfull transaction
            MessageBox.Show(String.Format("You successfully bought {0} shares from {1}. The total cost was {2}.", txtAmountBuy.Text, selectedCompany, txtCostBuy.Text), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /**
         * Fills the sell combobox with the names of companies
         */
        private void cmbSell_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCompany = cmbSell.SelectedItem.ToString();
            priceSelectedSell = sell.getPrice(selectedCompany);
            txtPriceSell.Text = priceSelectedSell;
            txtAmountSell.Text = string.Empty;
            txtCostSell.Text = string.Empty;
        }

        /**
         * Shows the amount of cost
         */
        private void txtAmountSell_TextChanged(object sender, EventArgs e)
        {
            sell.calculateCost(txtAmountSell, txtPriceSell, txtCostSell, cmbSell);
        }

        /**
         * Sells a number of stocks
         */
        private void btnSell_Click(object sender, EventArgs e)
        {
            string selectedCompany = cmbSell.SelectedItem.ToString();
            string symbolOfCompany = sell.getSymbol(selectedCompany);
            string idOfCompany = sell.getId(selectedCompany);
            sell.sellShares(cmbSell, idOfCompany, txtAmountSell, txtCostSell, symbolOfCompany, selectedCompany, priceSelectedSell);

            // update the money label
            fillMoney();

            // clear previous items in portfolio
            listPortfolio.Columns.Clear();
            listPortfolio.Items.Clear();

            // update the portfolio
            fillPortfolio();

            // clear previous items in sell combobox
            cmbSell.Items.Clear();

            // update sell combobox
            fillSellComboBox();

            // clear previous items in history
            listHistory.Columns.Clear();
            listHistory.Items.Clear();

            // update the history
            fillHistory();
        }

        /**
         *Shows the report form
         */
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.Show();
        }

        /**
         *  Shows the account form
         */
        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount account = new frmAccount(this);
            account.Show();
        }

        /**
         * Exits the application
         */
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Shows the about dialog
         */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application lets you view and manage stocks. \nMade by Aleksandar Tanchev.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System;
using System.Windows.Forms;

namespace StockMarket
{
    public partial class frmReport: Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PortfolioDataSet.portfolio' table. You can move, or remove it, as needed.
            this.portfolioTableAdapter.Fill(this.PortfolioDataSet.portfolio);

            this.reportViewer1.RefreshReport();
        }
    }
}

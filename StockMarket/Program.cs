using System;
using System.Windows.Forms;

namespace StockMarket
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AccountManagement check = new AccountManagement();

            // check if account exists and show the appropriate form
            if (check.AccountExists == 0)
                Application.Run(new frmCreateAccount());
            else
                Application.Run(new frmStockMarket());
        }
    }
}

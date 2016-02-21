using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            if (check.checkAccount() == 0)
                Application.Run(new frmCreateAccount());
            else
                Application.Run(new frmStockMarket());
        }
    }
}

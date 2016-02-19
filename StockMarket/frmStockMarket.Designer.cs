namespace StockMarket
{
    partial class frmStockMarket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.listHistory = new System.Windows.Forms.ListView();
            this.tabSell = new System.Windows.Forms.TabPage();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblCostSell = new System.Windows.Forms.Label();
            this.txtCostSell = new System.Windows.Forms.TextBox();
            this.lblAmountSell = new System.Windows.Forms.Label();
            this.txtAmountSell = new System.Windows.Forms.TextBox();
            this.txtPriceSell = new System.Windows.Forms.TextBox();
            this.lblPriceSell = new System.Windows.Forms.Label();
            this.cmbSell = new System.Windows.Forms.ComboBox();
            this.lblChooseSell = new System.Windows.Forms.Label();
            this.tabBuy = new System.Windows.Forms.TabPage();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblCostBuy = new System.Windows.Forms.Label();
            this.txtCostBuy = new System.Windows.Forms.TextBox();
            this.lblAmountBuy = new System.Windows.Forms.Label();
            this.txtAmountBuy = new System.Windows.Forms.TextBox();
            this.txtPriceBuy = new System.Windows.Forms.TextBox();
            this.lblPriceBuy = new System.Windows.Forms.Label();
            this.cmbBuy = new System.Windows.Forms.ComboBox();
            this.lblChooseBuy = new System.Windows.Forms.Label();
            this.tabQuote = new System.Windows.Forms.TabPage();
            this.btnSearchQuote = new System.Windows.Forms.Button();
            this.txtSearchQuote = new System.Windows.Forms.TextBox();
            this.lblSearchQuote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listQuote = new System.Windows.Forms.ListView();
            this.tabPortfolio = new System.Windows.Forms.TabPage();
            this.btnSearchPortfolio = new System.Windows.Forms.Button();
            this.txtSearchPortfolio = new System.Windows.Forms.TextBox();
            this.lblSearchPortfolio = new System.Windows.Forms.Label();
            this.listPortfolio = new System.Windows.Forms.ListView();
            this.tabStockMarket = new System.Windows.Forms.TabControl();
            this.lblMoney = new System.Windows.Forms.Label();
            this.menuStockMarket = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabHistory.SuspendLayout();
            this.tabSell.SuspendLayout();
            this.tabBuy.SuspendLayout();
            this.tabQuote.SuspendLayout();
            this.tabPortfolio.SuspendLayout();
            this.tabStockMarket.SuspendLayout();
            this.menuStockMarket.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(58, 13);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome, ";
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.listHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Size = new System.Drawing.Size(576, 310);
            this.tabHistory.TabIndex = 4;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // listHistory
            // 
            this.listHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listHistory.Location = new System.Drawing.Point(6, 3);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(564, 301);
            this.listHistory.TabIndex = 1;
            this.listHistory.UseCompatibleStateImageBehavior = false;
            // 
            // tabSell
            // 
            this.tabSell.Controls.Add(this.btnSell);
            this.tabSell.Controls.Add(this.lblCostSell);
            this.tabSell.Controls.Add(this.txtCostSell);
            this.tabSell.Controls.Add(this.lblAmountSell);
            this.tabSell.Controls.Add(this.txtAmountSell);
            this.tabSell.Controls.Add(this.txtPriceSell);
            this.tabSell.Controls.Add(this.lblPriceSell);
            this.tabSell.Controls.Add(this.cmbSell);
            this.tabSell.Controls.Add(this.lblChooseSell);
            this.tabSell.Location = new System.Drawing.Point(4, 22);
            this.tabSell.Name = "tabSell";
            this.tabSell.Size = new System.Drawing.Size(576, 310);
            this.tabSell.TabIndex = 3;
            this.tabSell.Text = "Sell";
            this.tabSell.UseVisualStyleBackColor = true;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(385, 196);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 17;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lblCostSell
            // 
            this.lblCostSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCostSell.AutoSize = true;
            this.lblCostSell.Location = new System.Drawing.Point(114, 173);
            this.lblCostSell.Name = "lblCostSell";
            this.lblCostSell.Size = new System.Drawing.Size(31, 13);
            this.lblCostSell.TabIndex = 16;
            this.lblCostSell.Text = "Cost:";
            // 
            // txtCostSell
            // 
            this.txtCostSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCostSell.Location = new System.Drawing.Point(221, 170);
            this.txtCostSell.Name = "txtCostSell";
            this.txtCostSell.ReadOnly = true;
            this.txtCostSell.Size = new System.Drawing.Size(239, 20);
            this.txtCostSell.TabIndex = 15;
            // 
            // lblAmountSell
            // 
            this.lblAmountSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmountSell.AutoSize = true;
            this.lblAmountSell.Location = new System.Drawing.Point(114, 147);
            this.lblAmountSell.Name = "lblAmountSell";
            this.lblAmountSell.Size = new System.Drawing.Size(73, 13);
            this.lblAmountSell.TabIndex = 14;
            this.lblAmountSell.Text = "Enter amount:";
            // 
            // txtAmountSell
            // 
            this.txtAmountSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmountSell.Location = new System.Drawing.Point(221, 144);
            this.txtAmountSell.Name = "txtAmountSell";
            this.txtAmountSell.Size = new System.Drawing.Size(239, 20);
            this.txtAmountSell.TabIndex = 13;
            this.txtAmountSell.TextChanged += new System.EventHandler(this.txtAmountSell_TextChanged);
            // 
            // txtPriceSell
            // 
            this.txtPriceSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPriceSell.Location = new System.Drawing.Point(221, 118);
            this.txtPriceSell.Name = "txtPriceSell";
            this.txtPriceSell.ReadOnly = true;
            this.txtPriceSell.Size = new System.Drawing.Size(239, 20);
            this.txtPriceSell.TabIndex = 12;
            // 
            // lblPriceSell
            // 
            this.lblPriceSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPriceSell.AutoSize = true;
            this.lblPriceSell.Location = new System.Drawing.Point(114, 121);
            this.lblPriceSell.Name = "lblPriceSell";
            this.lblPriceSell.Size = new System.Drawing.Size(34, 13);
            this.lblPriceSell.TabIndex = 11;
            this.lblPriceSell.Text = "Price:";
            // 
            // cmbSell
            // 
            this.cmbSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSell.FormattingEnabled = true;
            this.cmbSell.Location = new System.Drawing.Point(221, 91);
            this.cmbSell.Name = "cmbSell";
            this.cmbSell.Size = new System.Drawing.Size(239, 21);
            this.cmbSell.TabIndex = 10;
            this.cmbSell.SelectedIndexChanged += new System.EventHandler(this.cmbSell_SelectedIndexChanged);
            // 
            // lblChooseSell
            // 
            this.lblChooseSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChooseSell.AutoSize = true;
            this.lblChooseSell.Location = new System.Drawing.Point(114, 94);
            this.lblChooseSell.Name = "lblChooseSell";
            this.lblChooseSell.Size = new System.Drawing.Size(101, 13);
            this.lblChooseSell.TabIndex = 9;
            this.lblChooseSell.Text = "Choose a company:";
            // 
            // tabBuy
            // 
            this.tabBuy.Controls.Add(this.btnBuy);
            this.tabBuy.Controls.Add(this.lblCostBuy);
            this.tabBuy.Controls.Add(this.txtCostBuy);
            this.tabBuy.Controls.Add(this.lblAmountBuy);
            this.tabBuy.Controls.Add(this.txtAmountBuy);
            this.tabBuy.Controls.Add(this.txtPriceBuy);
            this.tabBuy.Controls.Add(this.lblPriceBuy);
            this.tabBuy.Controls.Add(this.cmbBuy);
            this.tabBuy.Controls.Add(this.lblChooseBuy);
            this.tabBuy.Location = new System.Drawing.Point(4, 22);
            this.tabBuy.Name = "tabBuy";
            this.tabBuy.Size = new System.Drawing.Size(576, 310);
            this.tabBuy.TabIndex = 2;
            this.tabBuy.Text = "Buy";
            this.tabBuy.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(385, 196);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 8;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblCostBuy
            // 
            this.lblCostBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCostBuy.AutoSize = true;
            this.lblCostBuy.Location = new System.Drawing.Point(114, 173);
            this.lblCostBuy.Name = "lblCostBuy";
            this.lblCostBuy.Size = new System.Drawing.Size(31, 13);
            this.lblCostBuy.TabIndex = 7;
            this.lblCostBuy.Text = "Cost:";
            // 
            // txtCostBuy
            // 
            this.txtCostBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCostBuy.Location = new System.Drawing.Point(221, 170);
            this.txtCostBuy.Name = "txtCostBuy";
            this.txtCostBuy.ReadOnly = true;
            this.txtCostBuy.Size = new System.Drawing.Size(239, 20);
            this.txtCostBuy.TabIndex = 6;
            // 
            // lblAmountBuy
            // 
            this.lblAmountBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmountBuy.AutoSize = true;
            this.lblAmountBuy.Location = new System.Drawing.Point(114, 147);
            this.lblAmountBuy.Name = "lblAmountBuy";
            this.lblAmountBuy.Size = new System.Drawing.Size(73, 13);
            this.lblAmountBuy.TabIndex = 5;
            this.lblAmountBuy.Text = "Enter amount:";
            // 
            // txtAmountBuy
            // 
            this.txtAmountBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmountBuy.Location = new System.Drawing.Point(221, 144);
            this.txtAmountBuy.Name = "txtAmountBuy";
            this.txtAmountBuy.Size = new System.Drawing.Size(239, 20);
            this.txtAmountBuy.TabIndex = 4;
            this.txtAmountBuy.TextChanged += new System.EventHandler(this.txtAmountBuy_TextChanged);
            // 
            // txtPriceBuy
            // 
            this.txtPriceBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPriceBuy.Location = new System.Drawing.Point(221, 118);
            this.txtPriceBuy.Name = "txtPriceBuy";
            this.txtPriceBuy.ReadOnly = true;
            this.txtPriceBuy.Size = new System.Drawing.Size(239, 20);
            this.txtPriceBuy.TabIndex = 3;
            // 
            // lblPriceBuy
            // 
            this.lblPriceBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPriceBuy.AutoSize = true;
            this.lblPriceBuy.Location = new System.Drawing.Point(114, 121);
            this.lblPriceBuy.Name = "lblPriceBuy";
            this.lblPriceBuy.Size = new System.Drawing.Size(34, 13);
            this.lblPriceBuy.TabIndex = 2;
            this.lblPriceBuy.Text = "Price:";
            // 
            // cmbBuy
            // 
            this.cmbBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuy.FormattingEnabled = true;
            this.cmbBuy.Location = new System.Drawing.Point(221, 91);
            this.cmbBuy.Name = "cmbBuy";
            this.cmbBuy.Size = new System.Drawing.Size(239, 21);
            this.cmbBuy.TabIndex = 1;
            this.cmbBuy.SelectedIndexChanged += new System.EventHandler(this.cmbBuy_SelectedIndexChanged);
            // 
            // lblChooseBuy
            // 
            this.lblChooseBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChooseBuy.AutoSize = true;
            this.lblChooseBuy.Location = new System.Drawing.Point(114, 94);
            this.lblChooseBuy.Name = "lblChooseBuy";
            this.lblChooseBuy.Size = new System.Drawing.Size(101, 13);
            this.lblChooseBuy.TabIndex = 0;
            this.lblChooseBuy.Text = "Choose a company:";
            // 
            // tabQuote
            // 
            this.tabQuote.Controls.Add(this.btnSearchQuote);
            this.tabQuote.Controls.Add(this.txtSearchQuote);
            this.tabQuote.Controls.Add(this.lblSearchQuote);
            this.tabQuote.Controls.Add(this.label1);
            this.tabQuote.Controls.Add(this.listQuote);
            this.tabQuote.Location = new System.Drawing.Point(4, 22);
            this.tabQuote.Name = "tabQuote";
            this.tabQuote.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuote.Size = new System.Drawing.Size(576, 310);
            this.tabQuote.TabIndex = 1;
            this.tabQuote.Text = "Quote";
            this.tabQuote.UseVisualStyleBackColor = true;
            // 
            // btnSearchQuote
            // 
            this.btnSearchQuote.Location = new System.Drawing.Point(495, 17);
            this.btnSearchQuote.Name = "btnSearchQuote";
            this.btnSearchQuote.Size = new System.Drawing.Size(75, 23);
            this.btnSearchQuote.TabIndex = 3;
            this.btnSearchQuote.Text = "Search";
            this.btnSearchQuote.UseVisualStyleBackColor = true;
            this.btnSearchQuote.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchQuote
            // 
            this.txtSearchQuote.Location = new System.Drawing.Point(6, 19);
            this.txtSearchQuote.Name = "txtSearchQuote";
            this.txtSearchQuote.Size = new System.Drawing.Size(483, 20);
            this.txtSearchQuote.TabIndex = 2;
            // 
            // lblSearchQuote
            // 
            this.lblSearchQuote.AutoSize = true;
            this.lblSearchQuote.Location = new System.Drawing.Point(6, 3);
            this.lblSearchQuote.Name = "lblSearchQuote";
            this.lblSearchQuote.Size = new System.Drawing.Size(223, 13);
            this.lblSearchQuote.TabIndex = 1;
            this.lblSearchQuote.Text = "Enter the name or the symbol of the company:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // listQuote
            // 
            this.listQuote.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listQuote.Location = new System.Drawing.Point(6, 46);
            this.listQuote.Name = "listQuote";
            this.listQuote.Size = new System.Drawing.Size(564, 258);
            this.listQuote.TabIndex = 0;
            this.listQuote.UseCompatibleStateImageBehavior = false;
            // 
            // tabPortfolio
            // 
            this.tabPortfolio.Controls.Add(this.btnSearchPortfolio);
            this.tabPortfolio.Controls.Add(this.txtSearchPortfolio);
            this.tabPortfolio.Controls.Add(this.lblSearchPortfolio);
            this.tabPortfolio.Controls.Add(this.listPortfolio);
            this.tabPortfolio.Location = new System.Drawing.Point(4, 22);
            this.tabPortfolio.Name = "tabPortfolio";
            this.tabPortfolio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPortfolio.Size = new System.Drawing.Size(576, 310);
            this.tabPortfolio.TabIndex = 0;
            this.tabPortfolio.Text = "Portfolio";
            this.tabPortfolio.UseVisualStyleBackColor = true;
            // 
            // btnSearchPortfolio
            // 
            this.btnSearchPortfolio.Location = new System.Drawing.Point(495, 17);
            this.btnSearchPortfolio.Name = "btnSearchPortfolio";
            this.btnSearchPortfolio.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPortfolio.TabIndex = 11;
            this.btnSearchPortfolio.Text = "Search";
            this.btnSearchPortfolio.UseVisualStyleBackColor = true;
            this.btnSearchPortfolio.Click += new System.EventHandler(this.btnSearchPortfolio_Click);
            // 
            // txtSearchPortfolio
            // 
            this.txtSearchPortfolio.Location = new System.Drawing.Point(6, 19);
            this.txtSearchPortfolio.Name = "txtSearchPortfolio";
            this.txtSearchPortfolio.Size = new System.Drawing.Size(483, 20);
            this.txtSearchPortfolio.TabIndex = 10;
            // 
            // lblSearchPortfolio
            // 
            this.lblSearchPortfolio.AutoSize = true;
            this.lblSearchPortfolio.Location = new System.Drawing.Point(6, 3);
            this.lblSearchPortfolio.Name = "lblSearchPortfolio";
            this.lblSearchPortfolio.Size = new System.Drawing.Size(223, 13);
            this.lblSearchPortfolio.TabIndex = 9;
            this.lblSearchPortfolio.Text = "Enter the name or the symbol of the company:";
            // 
            // listPortfolio
            // 
            this.listPortfolio.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listPortfolio.Location = new System.Drawing.Point(6, 46);
            this.listPortfolio.Name = "listPortfolio";
            this.listPortfolio.Size = new System.Drawing.Size(564, 258);
            this.listPortfolio.TabIndex = 8;
            this.listPortfolio.UseCompatibleStateImageBehavior = false;
            // 
            // tabStockMarket
            // 
            this.tabStockMarket.Controls.Add(this.tabPortfolio);
            this.tabStockMarket.Controls.Add(this.tabQuote);
            this.tabStockMarket.Controls.Add(this.tabBuy);
            this.tabStockMarket.Controls.Add(this.tabSell);
            this.tabStockMarket.Controls.Add(this.tabHistory);
            this.tabStockMarket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabStockMarket.Location = new System.Drawing.Point(0, 45);
            this.tabStockMarket.Multiline = true;
            this.tabStockMarket.Name = "tabStockMarket";
            this.tabStockMarket.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabStockMarket.SelectedIndex = 0;
            this.tabStockMarket.Size = new System.Drawing.Size(584, 336);
            this.tabStockMarket.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabStockMarket.TabIndex = 6;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(188, 29);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(45, 13);
            this.lblMoney.TabIndex = 7;
            this.lblMoney.Text = "Money: ";
            // 
            // menuStockMarket
            // 
            this.menuStockMarket.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStockMarket.Location = new System.Drawing.Point(0, 0);
            this.menuStockMarket.Name = "menuStockMarket";
            this.menuStockMarket.Size = new System.Drawing.Size(584, 24);
            this.menuStockMarket.TabIndex = 8;
            this.menuStockMarket.Text = "menuStockMarket";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // frmStockMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.tabStockMarket);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStockMarket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStockMarket;
            this.MaximizeBox = false;
            this.Name = "frmStockMarket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Market";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStockMarket_FormClosing);
            this.Load += new System.EventHandler(this.frmStockMarket_Load);
            this.tabHistory.ResumeLayout(false);
            this.tabSell.ResumeLayout(false);
            this.tabSell.PerformLayout();
            this.tabBuy.ResumeLayout(false);
            this.tabBuy.PerformLayout();
            this.tabQuote.ResumeLayout(false);
            this.tabQuote.PerformLayout();
            this.tabPortfolio.ResumeLayout(false);
            this.tabPortfolio.PerformLayout();
            this.tabStockMarket.ResumeLayout(false);
            this.menuStockMarket.ResumeLayout(false);
            this.menuStockMarket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabSell;
        private System.Windows.Forms.TabPage tabBuy;
        private System.Windows.Forms.TabPage tabQuote;
        private System.Windows.Forms.TabPage tabPortfolio;
        private System.Windows.Forms.TabControl tabStockMarket;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.ListView listQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchQuote;
        private System.Windows.Forms.TextBox txtSearchQuote;
        private System.Windows.Forms.Label lblSearchQuote;
        private System.Windows.Forms.ComboBox cmbBuy;
        private System.Windows.Forms.Label lblChooseBuy;
        private System.Windows.Forms.TextBox txtPriceBuy;
        private System.Windows.Forms.Label lblPriceBuy;
        private System.Windows.Forms.Label lblCostBuy;
        private System.Windows.Forms.TextBox txtCostBuy;
        private System.Windows.Forms.Label lblAmountBuy;
        private System.Windows.Forms.TextBox txtAmountBuy;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ListView listPortfolio;
        private System.Windows.Forms.Button btnSearchPortfolio;
        private System.Windows.Forms.TextBox txtSearchPortfolio;
        private System.Windows.Forms.Label lblSearchPortfolio;
        private System.Windows.Forms.ListView listHistory;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblCostSell;
        private System.Windows.Forms.TextBox txtCostSell;
        private System.Windows.Forms.Label lblAmountSell;
        private System.Windows.Forms.TextBox txtAmountSell;
        private System.Windows.Forms.TextBox txtPriceSell;
        private System.Windows.Forms.Label lblPriceSell;
        private System.Windows.Forms.ComboBox cmbSell;
        private System.Windows.Forms.Label lblChooseSell;
        private System.Windows.Forms.MenuStrip menuStockMarket;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}
namespace BankApplication.Forms
{
    partial class BankMainView : Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openANewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAnAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferFundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountManagementToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.contactSupportToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountManagementToolStripMenuItem
            // 
            this.accountManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openANewAccountToolStripMenuItem,
            this.closeAnAccountToolStripMenuItem,
            this.transferAccountToolStripMenuItem,
            this.viewAllAccountsToolStripMenuItem});
            this.accountManagementToolStripMenuItem.Name = "accountManagementToolStripMenuItem";
            this.accountManagementToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.accountManagementToolStripMenuItem.Text = "Account Management";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferFundsToolStripMenuItem,
            this.viewAllTransactionsToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // contactSupportToolStripMenuItem
            // 
            this.contactSupportToolStripMenuItem.Name = "contactSupportToolStripMenuItem";
            this.contactSupportToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.contactSupportToolStripMenuItem.Text = "Contact support";
            // 
            // openANewAccountToolStripMenuItem
            // 
            this.openANewAccountToolStripMenuItem.Name = "openANewAccountToolStripMenuItem";
            this.openANewAccountToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openANewAccountToolStripMenuItem.Text = "Open a new account";
            // 
            // closeAnAccountToolStripMenuItem
            // 
            this.closeAnAccountToolStripMenuItem.Name = "closeAnAccountToolStripMenuItem";
            this.closeAnAccountToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.closeAnAccountToolStripMenuItem.Text = "Close an account";
            // 
            // transferAccountToolStripMenuItem
            // 
            this.transferAccountToolStripMenuItem.Name = "transferAccountToolStripMenuItem";
            this.transferAccountToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.transferAccountToolStripMenuItem.Text = "Transfer account";
            // 
            // viewAllAccountsToolStripMenuItem
            // 
            this.viewAllAccountsToolStripMenuItem.Name = "viewAllAccountsToolStripMenuItem";
            this.viewAllAccountsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.viewAllAccountsToolStripMenuItem.Text = "View all accounts";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // transferFundsToolStripMenuItem
            // 
            this.transferFundsToolStripMenuItem.Name = "transferFundsToolStripMenuItem";
            this.transferFundsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.transferFundsToolStripMenuItem.Text = "Transfer funds";
            // 
            // viewAllTransactionsToolStripMenuItem
            // 
            this.viewAllTransactionsToolStripMenuItem.Name = "viewAllTransactionsToolStripMenuItem";
            this.viewAllTransactionsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.viewAllTransactionsToolStripMenuItem.Text = "View all transactions";
            // 
            // BankMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BankMainView";
            this.Text = "BankMainView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountManagementToolStripMenuItem;
        private ToolStripMenuItem openANewAccountToolStripMenuItem;
        private ToolStripMenuItem closeAnAccountToolStripMenuItem;
        private ToolStripMenuItem transferAccountToolStripMenuItem;
        private ToolStripMenuItem viewAllAccountsToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem transferFundsToolStripMenuItem;
        private ToolStripMenuItem viewAllTransactionsToolStripMenuItem;
        private ToolStripMenuItem contactSupportToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}
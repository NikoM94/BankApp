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
            this.openANewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAnAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferFundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountListingPL = new System.Windows.Forms.Panel();
            this.SearchTransactionBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchToDTP = new System.Windows.Forms.DateTimePicker();
            this.SearchFromDTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ExportTransactionBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTransactionsTB = new System.Windows.Forms.TextBox();
            this.AccountsDG = new System.Windows.Forms.DataGridView();
            this.AccountsCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchOptionsTextRB = new System.Windows.Forms.RadioButton();
            this.SearchOptionsFromToRB = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.AccountListingPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDG)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
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
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferFundsToolStripMenuItem,
            this.viewAllTransactionsToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
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
            // contactSupportToolStripMenuItem
            // 
            this.contactSupportToolStripMenuItem.Name = "contactSupportToolStripMenuItem";
            this.contactSupportToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.contactSupportToolStripMenuItem.Text = "Contact support";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // AccountListingPL
            // 
            this.AccountListingPL.AutoSize = true;
            this.AccountListingPL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AccountListingPL.Controls.Add(this.SearchOptionsFromToRB);
            this.AccountListingPL.Controls.Add(this.SearchOptionsTextRB);
            this.AccountListingPL.Controls.Add(this.SearchTransactionBT);
            this.AccountListingPL.Controls.Add(this.label4);
            this.AccountListingPL.Controls.Add(this.SearchToDTP);
            this.AccountListingPL.Controls.Add(this.SearchFromDTP);
            this.AccountListingPL.Controls.Add(this.label3);
            this.AccountListingPL.Controls.Add(this.ExportTransactionBT);
            this.AccountListingPL.Controls.Add(this.label2);
            this.AccountListingPL.Controls.Add(this.SearchTransactionsTB);
            this.AccountListingPL.Controls.Add(this.AccountsDG);
            this.AccountListingPL.Controls.Add(this.AccountsCB);
            this.AccountListingPL.Controls.Add(this.label1);
            this.AccountListingPL.Location = new System.Drawing.Point(12, 27);
            this.AccountListingPL.Name = "AccountListingPL";
            this.AccountListingPL.Size = new System.Drawing.Size(494, 591);
            this.AccountListingPL.TabIndex = 1;
            // 
            // SearchTransactionBT
            // 
            this.SearchTransactionBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchTransactionBT.Location = new System.Drawing.Point(411, 74);
            this.SearchTransactionBT.Name = "SearchTransactionBT";
            this.SearchTransactionBT.Size = new System.Drawing.Size(66, 31);
            this.SearchTransactionBT.TabIndex = 10;
            this.SearchTransactionBT.Text = "Search";
            this.SearchTransactionBT.UseVisualStyleBackColor = true;
            this.SearchTransactionBT.Click += new System.EventHandler(this.SearchTransactionBT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(310, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search to";
            // 
            // SearchToDTP
            // 
            this.SearchToDTP.CustomFormat = "dd/MM/yyyy";
            this.SearchToDTP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchToDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SearchToDTP.Location = new System.Drawing.Point(310, 78);
            this.SearchToDTP.Name = "SearchToDTP";
            this.SearchToDTP.Size = new System.Drawing.Size(95, 25);
            this.SearchToDTP.TabIndex = 8;
            // 
            // SearchFromDTP
            // 
            this.SearchFromDTP.CustomFormat = "dd/MM/yyyy";
            this.SearchFromDTP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchFromDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SearchFromDTP.Location = new System.Drawing.Point(210, 78);
            this.SearchFromDTP.Name = "SearchFromDTP";
            this.SearchFromDTP.Size = new System.Drawing.Size(94, 25);
            this.SearchFromDTP.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(210, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search from";
            // 
            // ExportTransactionBT
            // 
            this.ExportTransactionBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExportTransactionBT.Location = new System.Drawing.Point(240, 26);
            this.ExportTransactionBT.Name = "ExportTransactionBT";
            this.ExportTransactionBT.Size = new System.Drawing.Size(76, 31);
            this.ExportTransactionBT.TabIndex = 5;
            this.ExportTransactionBT.Text = "Export";
            this.ExportTransactionBT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search transactions";
            // 
            // SearchTransactionsTB
            // 
            this.SearchTransactionsTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTransactionsTB.Location = new System.Drawing.Point(11, 74);
            this.SearchTransactionsTB.Name = "SearchTransactionsTB";
            this.SearchTransactionsTB.Size = new System.Drawing.Size(193, 29);
            this.SearchTransactionsTB.TabIndex = 3;
            // 
            // AccountsDG
            // 
            this.AccountsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsDG.Location = new System.Drawing.Point(11, 109);
            this.AccountsDG.Name = "AccountsDG";
            this.AccountsDG.RowTemplate.Height = 25;
            this.AccountsDG.Size = new System.Drawing.Size(466, 469);
            this.AccountsDG.TabIndex = 2;
            // 
            // AccountsCB
            // 
            this.AccountsCB.FormattingEnabled = true;
            this.AccountsCB.Location = new System.Drawing.Point(11, 27);
            this.AccountsCB.Name = "AccountsCB";
            this.AccountsCB.Size = new System.Drawing.Size(223, 29);
            this.AccountsCB.TabIndex = 0;
            this.AccountsCB.SelectedIndexChanged += new System.EventHandler(this.AccountsCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "My accounts";
            // 
            // SearchOptionsTextRB
            // 
            this.SearchOptionsTextRB.AutoSize = true;
            this.SearchOptionsTextRB.Location = new System.Drawing.Point(358, 9);
            this.SearchOptionsTextRB.Name = "SearchOptionsTextRB";
            this.SearchOptionsTextRB.Size = new System.Drawing.Size(104, 25);
            this.SearchOptionsTextRB.TabIndex = 11;
            this.SearchOptionsTextRB.TabStop = true;
            this.SearchOptionsTextRB.Text = "Search text";
            this.SearchOptionsTextRB.UseVisualStyleBackColor = true;
            // 
            // SearchOptionsFromToRB
            // 
            this.SearchOptionsFromToRB.AutoSize = true;
            this.SearchOptionsFromToRB.Location = new System.Drawing.Point(358, 32);
            this.SearchOptionsFromToRB.Name = "SearchOptionsFromToRB";
            this.SearchOptionsFromToRB.Size = new System.Drawing.Size(133, 25);
            this.SearchOptionsFromToRB.TabIndex = 12;
            this.SearchOptionsFromToRB.TabStop = true;
            this.SearchOptionsFromToRB.Text = "Search from/to";
            this.SearchOptionsFromToRB.UseVisualStyleBackColor = true;
            // 
            // BankMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(517, 630);
            this.Controls.Add(this.AccountListingPL);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BankMainView";
            this.Text = "BankMainView";
            this.Load += new System.EventHandler(this.BankMainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AccountListingPL.ResumeLayout(false);
            this.AccountListingPL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDG)).EndInit();
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
        private Panel AccountListingPL;
        private Label label4;
        private DateTimePicker SearchToDTP;
        private DateTimePicker SearchFromDTP;
        private Label label3;
        private Button ExportTransactionBT;
        private Label label2;
        private TextBox SearchTransactionsTB;
        private DataGridView AccountsDG;
        private ComboBox AccountsCB;
        private Label label1;
        private Button SearchTransactionBT;
        private RadioButton SearchOptionsFromToRB;
        private RadioButton SearchOptionsTextRB;
    }
}
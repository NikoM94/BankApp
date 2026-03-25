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
            this.ResetSearchBT = new System.Windows.Forms.Button();
            this.SearchOptionsFromToRB = new System.Windows.Forms.RadioButton();
            this.SearchOptionsTextRB = new System.Windows.Forms.RadioButton();
            this.SearchTransactionBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchToDTP = new System.Windows.Forms.DateTimePicker();
            this.SearchFromDTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTransactionsTB = new System.Windows.Forms.TextBox();
            this.AccountsDG = new System.Windows.Forms.DataGridView();
            this.AccountsCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateTransactionPL = new System.Windows.Forms.Panel();
            this.TransferAmountTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TransferBT = new System.Windows.Forms.Button();
            this.MessageLB = new System.Windows.Forms.Label();
            this.TransferMessageRTB = new System.Windows.Forms.RichTextBox();
            this.TransferToTB = new System.Windows.Forms.TextBox();
            this.TransferToLB = new System.Windows.Forms.Label();
            this.TranferToLB = new System.Windows.Forms.Label();
            this.TransferFromCB = new System.Windows.Forms.ComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BalanceLB = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.AccountListingPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDG)).BeginInit();
            this.CreateTransactionPL.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.transferFundsToolStripMenuItem.Click += new System.EventHandler(this.transferFundsToolStripMenuItem_Click);
            // 
            // viewAllTransactionsToolStripMenuItem
            // 
            this.viewAllTransactionsToolStripMenuItem.Name = "viewAllTransactionsToolStripMenuItem";
            this.viewAllTransactionsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.viewAllTransactionsToolStripMenuItem.Text = "View all transactions";
            this.viewAllTransactionsToolStripMenuItem.Click += new System.EventHandler(this.viewAllTransactionsToolStripMenuItem_Click);
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
            this.AccountListingPL.Controls.Add(this.ResetSearchBT);
            this.AccountListingPL.Controls.Add(this.SearchOptionsFromToRB);
            this.AccountListingPL.Controls.Add(this.SearchOptionsTextRB);
            this.AccountListingPL.Controls.Add(this.SearchTransactionBT);
            this.AccountListingPL.Controls.Add(this.label4);
            this.AccountListingPL.Controls.Add(this.SearchToDTP);
            this.AccountListingPL.Controls.Add(this.SearchFromDTP);
            this.AccountListingPL.Controls.Add(this.label3);
            this.AccountListingPL.Controls.Add(this.label2);
            this.AccountListingPL.Controls.Add(this.SearchTransactionsTB);
            this.AccountListingPL.Controls.Add(this.AccountsDG);
            this.AccountListingPL.Controls.Add(this.AccountsCB);
            this.AccountListingPL.Controls.Add(this.label1);
            this.AccountListingPL.Location = new System.Drawing.Point(12, 27);
            this.AccountListingPL.Name = "AccountListingPL";
            this.AccountListingPL.Size = new System.Drawing.Size(495, 591);
            this.AccountListingPL.TabIndex = 1;
            // 
            // ResetSearchBT
            // 
            this.ResetSearchBT.Location = new System.Drawing.Point(411, 45);
            this.ResetSearchBT.Name = "ResetSearchBT";
            this.ResetSearchBT.Size = new System.Drawing.Size(66, 30);
            this.ResetSearchBT.TabIndex = 13;
            this.ResetSearchBT.Text = "Reset";
            this.ResetSearchBT.UseVisualStyleBackColor = true;
            this.ResetSearchBT.Click += new System.EventHandler(this.ResetSearchBT_Click);
            // 
            // SearchOptionsFromToRB
            // 
            this.SearchOptionsFromToRB.AutoSize = true;
            this.SearchOptionsFromToRB.Location = new System.Drawing.Point(242, 31);
            this.SearchOptionsFromToRB.Name = "SearchOptionsFromToRB";
            this.SearchOptionsFromToRB.Size = new System.Drawing.Size(133, 25);
            this.SearchOptionsFromToRB.TabIndex = 12;
            this.SearchOptionsFromToRB.TabStop = true;
            this.SearchOptionsFromToRB.Text = "Search from/to";
            this.SearchOptionsFromToRB.UseVisualStyleBackColor = true;
            // 
            // SearchOptionsTextRB
            // 
            this.SearchOptionsTextRB.AutoSize = true;
            this.SearchOptionsTextRB.Location = new System.Drawing.Point(242, 10);
            this.SearchOptionsTextRB.Name = "SearchOptionsTextRB";
            this.SearchOptionsTextRB.Size = new System.Drawing.Size(104, 25);
            this.SearchOptionsTextRB.TabIndex = 11;
            this.SearchOptionsTextRB.TabStop = true;
            this.SearchOptionsTextRB.Text = "Search text";
            this.SearchOptionsTextRB.UseVisualStyleBackColor = true;
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
            // CreateTransactionPL
            // 
            this.CreateTransactionPL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CreateTransactionPL.Controls.Add(this.panel1);
            this.CreateTransactionPL.Controls.Add(this.label6);
            this.CreateTransactionPL.Controls.Add(this.TransferAmountTB);
            this.CreateTransactionPL.Controls.Add(this.label5);
            this.CreateTransactionPL.Controls.Add(this.TransferBT);
            this.CreateTransactionPL.Controls.Add(this.MessageLB);
            this.CreateTransactionPL.Controls.Add(this.TransferMessageRTB);
            this.CreateTransactionPL.Controls.Add(this.TransferToTB);
            this.CreateTransactionPL.Controls.Add(this.TransferToLB);
            this.CreateTransactionPL.Controls.Add(this.TranferToLB);
            this.CreateTransactionPL.Controls.Add(this.TransferFromCB);
            this.CreateTransactionPL.Location = new System.Drawing.Point(12, 27);
            this.CreateTransactionPL.Name = "CreateTransactionPL";
            this.CreateTransactionPL.Size = new System.Drawing.Size(495, 591);
            this.CreateTransactionPL.TabIndex = 2;
            this.CreateTransactionPL.Visible = false;
            // 
            // TransferAmountTB
            // 
            this.TransferAmountTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransferAmountTB.Location = new System.Drawing.Point(151, 221);
            this.TransferAmountTB.Name = "TransferAmountTB";
            this.TransferAmountTB.Size = new System.Drawing.Size(195, 29);
            this.TransferAmountTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(151, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // TransferBT
            // 
            this.TransferBT.Location = new System.Drawing.Point(149, 403);
            this.TransferBT.Name = "TransferBT";
            this.TransferBT.Size = new System.Drawing.Size(197, 56);
            this.TransferBT.TabIndex = 7;
            this.TransferBT.Text = "Transfer";
            this.TransferBT.UseVisualStyleBackColor = true;
            this.TransferBT.Click += new System.EventHandler(this.TransferBT_Click);
            // 
            // MessageLB
            // 
            this.MessageLB.AutoSize = true;
            this.MessageLB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessageLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageLB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageLB.Location = new System.Drawing.Point(151, 263);
            this.MessageLB.Name = "MessageLB";
            this.MessageLB.Size = new System.Drawing.Size(63, 19);
            this.MessageLB.TabIndex = 6;
            this.MessageLB.Text = "Message";
            // 
            // TransferMessageRTB
            // 
            this.TransferMessageRTB.Location = new System.Drawing.Point(151, 282);
            this.TransferMessageRTB.Name = "TransferMessageRTB";
            this.TransferMessageRTB.Size = new System.Drawing.Size(195, 115);
            this.TransferMessageRTB.TabIndex = 5;
            this.TransferMessageRTB.Text = "";
            // 
            // TransferToTB
            // 
            this.TransferToTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransferToTB.Location = new System.Drawing.Point(151, 158);
            this.TransferToTB.Name = "TransferToTB";
            this.TransferToTB.Size = new System.Drawing.Size(195, 29);
            this.TransferToTB.TabIndex = 4;
            // 
            // TransferToLB
            // 
            this.TransferToLB.AutoSize = true;
            this.TransferToLB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TransferToLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransferToLB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferToLB.Location = new System.Drawing.Point(151, 55);
            this.TransferToLB.Name = "TransferToLB";
            this.TransferToLB.Size = new System.Drawing.Size(89, 19);
            this.TransferToLB.TabIndex = 3;
            this.TransferToLB.Text = "Transfer from";
            // 
            // TranferToLB
            // 
            this.TranferToLB.AutoSize = true;
            this.TranferToLB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TranferToLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TranferToLB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TranferToLB.Location = new System.Drawing.Point(151, 140);
            this.TranferToLB.Name = "TranferToLB";
            this.TranferToLB.Size = new System.Drawing.Size(73, 19);
            this.TranferToLB.TabIndex = 2;
            this.TranferToLB.Text = "Transfer to";
            // 
            // TransferFromCB
            // 
            this.TransferFromCB.FormattingEnabled = true;
            this.TransferFromCB.Location = new System.Drawing.Point(151, 73);
            this.TransferFromCB.Name = "TransferFromCB";
            this.TransferFromCB.Size = new System.Drawing.Size(195, 29);
            this.TransferFromCB.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Available balance:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.BalanceLB);
            this.panel1.Location = new System.Drawing.Point(290, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 34);
            this.panel1.TabIndex = 11;
            // 
            // BalanceLB
            // 
            this.BalanceLB.AutoSize = true;
            this.BalanceLB.Location = new System.Drawing.Point(5, 6);
            this.BalanceLB.Name = "BalanceLB";
            this.BalanceLB.Size = new System.Drawing.Size(52, 21);
            this.BalanceLB.TabIndex = 0;
            this.BalanceLB.Text = "label7";
            // 
            // BankMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(517, 630);
            this.Controls.Add(this.CreateTransactionPL);
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
            this.CreateTransactionPL.ResumeLayout(false);
            this.CreateTransactionPL.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Label label2;
        private TextBox SearchTransactionsTB;
        private DataGridView AccountsDG;
        private ComboBox AccountsCB;
        private Label label1;
        private Button SearchTransactionBT;
        private RadioButton SearchOptionsFromToRB;
        private RadioButton SearchOptionsTextRB;
        private Button ResetSearchBT;
        private Panel CreateTransactionPL;
        private Label MessageLB;
        private RichTextBox TransferMessageRTB;
        private TextBox TransferToTB;
        private Label TransferToLB;
        private Label TranferToLB;
        private ComboBox TransferFromCB;
        private Button TransferBT;
        private TextBox TransferAmountTB;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private HelpProvider helpProvider1;
        private Label BalanceLB;
    }
}
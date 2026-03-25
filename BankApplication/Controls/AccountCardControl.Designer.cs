namespace BankApplication.Controls
{
    partial class AccountCardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BalanceLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountNumberLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BalanceLB
            // 
            this.BalanceLB.AutoSize = true;
            this.BalanceLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BalanceLB.Location = new System.Drawing.Point(107, 55);
            this.BalanceLB.Name = "BalanceLB";
            this.BalanceLB.Size = new System.Drawing.Size(19, 21);
            this.BalanceLB.TabIndex = 0;
            this.BalanceLB.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account #:";
            // 
            // AccountNumberLB
            // 
            this.AccountNumberLB.AutoSize = true;
            this.AccountNumberLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountNumberLB.Location = new System.Drawing.Point(108, 25);
            this.AccountNumberLB.Name = "AccountNumberLB";
            this.AccountNumberLB.Size = new System.Drawing.Size(32, 21);
            this.AccountNumberLB.TabIndex = 2;
            this.AccountNumberLB.Text = "NA";
            // 
            // AccountCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccountNumberLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BalanceLB);
            this.Name = "AccountCardControl";
            this.Size = new System.Drawing.Size(485, 115);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label BalanceLB;
        private Label label1;
        private Label label2;
        private Label AccountNumberLB;
    }
}

namespace BankApplication.Forms
{
    partial class StartUpFM
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
            this.LoginBT = new System.Windows.Forms.Button();
            this.RegisterBT = new System.Windows.Forms.Button();
            this.RecoveryBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginBT
            // 
            this.LoginBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBT.Location = new System.Drawing.Point(14, 12);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(101, 52);
            this.LoginBT.TabIndex = 0;
            this.LoginBT.Text = "Log In";
            this.LoginBT.UseVisualStyleBackColor = true;
            this.LoginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // RegisterBT
            // 
            this.RegisterBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterBT.Location = new System.Drawing.Point(121, 12);
            this.RegisterBT.Name = "RegisterBT";
            this.RegisterBT.Size = new System.Drawing.Size(101, 52);
            this.RegisterBT.TabIndex = 1;
            this.RegisterBT.Text = "Register";
            this.RegisterBT.UseVisualStyleBackColor = true;
            this.RegisterBT.Click += new System.EventHandler(this.RegisterBT_Click);
            // 
            // RecoveryBT
            // 
            this.RecoveryBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecoveryBT.Location = new System.Drawing.Point(228, 12);
            this.RecoveryBT.Name = "RecoveryBT";
            this.RecoveryBT.Size = new System.Drawing.Size(101, 52);
            this.RecoveryBT.TabIndex = 2;
            this.RecoveryBT.Text = "Recover account";
            this.RecoveryBT.UseVisualStyleBackColor = true;
            this.RecoveryBT.Click += new System.EventHandler(this.RecoveryBT_Click);
            // 
            // StartUpFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 78);
            this.Controls.Add(this.RecoveryBT);
            this.Controls.Add(this.RegisterBT);
            this.Controls.Add(this.LoginBT);
            this.Name = "StartUpFM";
            this.Text = "LoginFM";
            this.ResumeLayout(false);

        }

        #endregion

        private Button LoginBT;
        private Button RegisterBT;
        private Button RecoveryBT;
    }
}
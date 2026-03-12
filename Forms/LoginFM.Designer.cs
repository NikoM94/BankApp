namespace BankApplication.Forms
{
    partial class LoginFM
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
            this.LoginFMLoginBT = new System.Windows.Forms.Button();
            this.LoginFMPasswordTB = new System.Windows.Forms.TextBox();
            this.LoginFMUsernameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginFMLoginBT
            // 
            this.LoginFMLoginBT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginFMLoginBT.Location = new System.Drawing.Point(12, 69);
            this.LoginFMLoginBT.Name = "LoginFMLoginBT";
            this.LoginFMLoginBT.Size = new System.Drawing.Size(236, 65);
            this.LoginFMLoginBT.TabIndex = 0;
            this.LoginFMLoginBT.Text = "Log in";
            this.LoginFMLoginBT.UseVisualStyleBackColor = true;
            this.LoginFMLoginBT.Click += new System.EventHandler(this.LoginFMLoginBT_Click);
            // 
            // LoginFMPasswordTB
            // 
            this.LoginFMPasswordTB.BackColor = System.Drawing.Color.LightGray;
            this.LoginFMPasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginFMPasswordTB.Location = new System.Drawing.Point(12, 40);
            this.LoginFMPasswordTB.Name = "LoginFMPasswordTB";
            this.LoginFMPasswordTB.PlaceholderText = "Password";
            this.LoginFMPasswordTB.Size = new System.Drawing.Size(236, 23);
            this.LoginFMPasswordTB.TabIndex = 1;
            this.LoginFMPasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginFMPasswordTB.UseSystemPasswordChar = true;
            // 
            // LoginFMUsernameTB
            // 
            this.LoginFMUsernameTB.BackColor = System.Drawing.Color.LightGray;
            this.LoginFMUsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginFMUsernameTB.Location = new System.Drawing.Point(12, 11);
            this.LoginFMUsernameTB.Name = "LoginFMUsernameTB";
            this.LoginFMUsernameTB.PlaceholderText = "Username";
            this.LoginFMUsernameTB.Size = new System.Drawing.Size(236, 23);
            this.LoginFMUsernameTB.TabIndex = 2;
            this.LoginFMUsernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginFMUsernameTB.UseSystemPasswordChar = true;
            // 
            // LoginFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 143);
            this.Controls.Add(this.LoginFMUsernameTB);
            this.Controls.Add(this.LoginFMPasswordTB);
            this.Controls.Add(this.LoginFMLoginBT);
            this.Name = "LoginFM";
            this.Text = "LoginFM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoginFMLoginBT;
        private TextBox LoginFMPasswordTB;
        private TextBox LoginFMUsernameTB;
    }
}
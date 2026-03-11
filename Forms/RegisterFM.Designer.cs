namespace BankApplication.Forms
{
    partial class RegisterFM
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
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.zipCodeTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.RegisterUserBT = new System.Windows.Forms.Button();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.firstNameCheckPL = new System.Windows.Forms.Panel();
            this.addressCheckPL = new System.Windows.Forms.Panel();
            this.lastNameCheckPL = new System.Windows.Forms.Panel();
            this.emailCheckPL = new System.Windows.Forms.Panel();
            this.zipCodeCheckPL = new System.Windows.Forms.Panel();
            this.cityCheckPL = new System.Windows.Forms.Panel();
            this.passwordCheckPL = new System.Windows.Forms.Panel();
            this.userNameCheckPL = new System.Windows.Forms.Panel();
            this.phoneCheckPL = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // firstNameTB
            // 
            this.firstNameTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.firstNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTB.Location = new System.Drawing.Point(12, 12);
            this.firstNameTB.MaxLength = 25;
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.PlaceholderText = "First name";
            this.firstNameTB.Size = new System.Drawing.Size(209, 29);
            this.firstNameTB.TabIndex = 0;
            this.firstNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstNameTB.TextChanged += new System.EventHandler(this.firstNameTB_TextChanged);
            // 
            // lastNameTB
            // 
            this.lastNameTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lastNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameTB.Location = new System.Drawing.Point(12, 47);
            this.lastNameTB.MaxLength = 25;
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.PlaceholderText = "Last name";
            this.lastNameTB.Size = new System.Drawing.Size(209, 29);
            this.lastNameTB.TabIndex = 1;
            this.lastNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastNameTB.TextChanged += new System.EventHandler(this.lastNameTB_TextChanged);
            // 
            // addressTB
            // 
            this.addressTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressTB.Location = new System.Drawing.Point(12, 82);
            this.addressTB.MaxLength = 25;
            this.addressTB.Name = "addressTB";
            this.addressTB.PlaceholderText = "Address";
            this.addressTB.Size = new System.Drawing.Size(209, 29);
            this.addressTB.TabIndex = 2;
            this.addressTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addressTB.TextChanged += new System.EventHandler(this.addressTB_TextChanged);
            // 
            // cityTB
            // 
            this.cityTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cityTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cityTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityTB.Location = new System.Drawing.Point(12, 117);
            this.cityTB.MaxLength = 25;
            this.cityTB.Name = "cityTB";
            this.cityTB.PlaceholderText = "City";
            this.cityTB.Size = new System.Drawing.Size(209, 29);
            this.cityTB.TabIndex = 3;
            this.cityTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cityTB.TextChanged += new System.EventHandler(this.cityTB_TextChanged);
            // 
            // zipCodeTB
            // 
            this.zipCodeTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zipCodeTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zipCodeTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.zipCodeTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zipCodeTB.Location = new System.Drawing.Point(12, 152);
            this.zipCodeTB.MaxLength = 25;
            this.zipCodeTB.Name = "zipCodeTB";
            this.zipCodeTB.PlaceholderText = "Zipcode";
            this.zipCodeTB.Size = new System.Drawing.Size(209, 29);
            this.zipCodeTB.TabIndex = 4;
            this.zipCodeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zipCodeTB.TextChanged += new System.EventHandler(this.zipCodeTB_TextChanged);
            // 
            // emailTB
            // 
            this.emailTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.emailTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTB.Location = new System.Drawing.Point(12, 187);
            this.emailTB.MaxLength = 25;
            this.emailTB.Name = "emailTB";
            this.emailTB.PlaceholderText = "Email address";
            this.emailTB.Size = new System.Drawing.Size(209, 29);
            this.emailTB.TabIndex = 5;
            this.emailTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailTB.TextChanged += new System.EventHandler(this.emailTB_TextChanged);
            // 
            // phoneTB
            // 
            this.phoneTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.phoneTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneTB.Location = new System.Drawing.Point(12, 222);
            this.phoneTB.MaxLength = 25;
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.PlaceholderText = "Phone number";
            this.phoneTB.Size = new System.Drawing.Size(209, 29);
            this.phoneTB.TabIndex = 6;
            this.phoneTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneTB.TextChanged += new System.EventHandler(this.phoneTB_TextChanged);
            // 
            // RegisterUserBT
            // 
            this.RegisterUserBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterUserBT.Location = new System.Drawing.Point(12, 327);
            this.RegisterUserBT.Name = "RegisterUserBT";
            this.RegisterUserBT.Size = new System.Drawing.Size(229, 47);
            this.RegisterUserBT.TabIndex = 7;
            this.RegisterUserBT.Text = "Register";
            this.RegisterUserBT.UseVisualStyleBackColor = true;
            this.RegisterUserBT.Click += new System.EventHandler(this.RegisterUserBT_Click);
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.usernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTB.Location = new System.Drawing.Point(12, 257);
            this.usernameTB.MaxLength = 25;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.PlaceholderText = "User name";
            this.usernameTB.Size = new System.Drawing.Size(209, 29);
            this.usernameTB.TabIndex = 8;
            this.usernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTB.TextChanged += new System.EventHandler(this.usernameTB_TextChanged);
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTB.Location = new System.Drawing.Point(12, 292);
            this.passwordTB.MaxLength = 25;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PlaceholderText = "Password";
            this.passwordTB.Size = new System.Drawing.Size(209, 29);
            this.passwordTB.TabIndex = 9;
            this.passwordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTB.UseSystemPasswordChar = true;
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged);
            // 
            // firstNameCheckPL
            // 
            this.firstNameCheckPL.BackColor = System.Drawing.Color.Red;
            this.firstNameCheckPL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstNameCheckPL.Location = new System.Drawing.Point(227, 12);
            this.firstNameCheckPL.Name = "firstNameCheckPL";
            this.firstNameCheckPL.Size = new System.Drawing.Size(14, 29);
            this.firstNameCheckPL.TabIndex = 10;
            // 
            // addressCheckPL
            // 
            this.addressCheckPL.BackColor = System.Drawing.Color.Red;
            this.addressCheckPL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addressCheckPL.Location = new System.Drawing.Point(227, 82);
            this.addressCheckPL.Name = "addressCheckPL";
            this.addressCheckPL.Size = new System.Drawing.Size(14, 29);
            this.addressCheckPL.TabIndex = 11;
            // 
            // lastNameCheckPL
            // 
            this.lastNameCheckPL.BackColor = System.Drawing.Color.Red;
            this.lastNameCheckPL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastNameCheckPL.Location = new System.Drawing.Point(227, 47);
            this.lastNameCheckPL.Name = "lastNameCheckPL";
            this.lastNameCheckPL.Size = new System.Drawing.Size(14, 29);
            this.lastNameCheckPL.TabIndex = 12;
            // 
            // emailCheckPL
            // 
            this.emailCheckPL.BackColor = System.Drawing.Color.Red;
            this.emailCheckPL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emailCheckPL.Location = new System.Drawing.Point(227, 187);
            this.emailCheckPL.Name = "emailCheckPL";
            this.emailCheckPL.Size = new System.Drawing.Size(14, 29);
            this.emailCheckPL.TabIndex = 14;
            // 
            // zipCodeCheckPL
            // 
            this.zipCodeCheckPL.BackColor = System.Drawing.Color.Red;
            this.zipCodeCheckPL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zipCodeCheckPL.Location = new System.Drawing.Point(227, 152);
            this.zipCodeCheckPL.Name = "zipCodeCheckPL";
            this.zipCodeCheckPL.Size = new System.Drawing.Size(14, 29);
            this.zipCodeCheckPL.TabIndex = 15;
            // 
            // cityCheckPL
            // 
            this.cityCheckPL.BackColor = System.Drawing.Color.Red;
            this.cityCheckPL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cityCheckPL.Location = new System.Drawing.Point(227, 117);
            this.cityCheckPL.Name = "cityCheckPL";
            this.cityCheckPL.Size = new System.Drawing.Size(14, 29);
            this.cityCheckPL.TabIndex = 13;
            // 
            // passwordCheckPL
            // 
            this.passwordCheckPL.BackColor = System.Drawing.Color.Red;
            this.passwordCheckPL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passwordCheckPL.Location = new System.Drawing.Point(227, 292);
            this.passwordCheckPL.Name = "passwordCheckPL";
            this.passwordCheckPL.Size = new System.Drawing.Size(14, 29);
            this.passwordCheckPL.TabIndex = 17;
            // 
            // userNameCheckPL
            // 
            this.userNameCheckPL.BackColor = System.Drawing.Color.Red;
            this.userNameCheckPL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userNameCheckPL.Location = new System.Drawing.Point(227, 257);
            this.userNameCheckPL.Name = "userNameCheckPL";
            this.userNameCheckPL.Size = new System.Drawing.Size(14, 29);
            this.userNameCheckPL.TabIndex = 18;
            // 
            // phoneCheckPL
            // 
            this.phoneCheckPL.BackColor = System.Drawing.Color.Red;
            this.phoneCheckPL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phoneCheckPL.Location = new System.Drawing.Point(227, 222);
            this.phoneCheckPL.Name = "phoneCheckPL";
            this.phoneCheckPL.Size = new System.Drawing.Size(14, 29);
            this.phoneCheckPL.TabIndex = 16;
            // 
            // RegisterFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 387);
            this.Controls.Add(this.passwordCheckPL);
            this.Controls.Add(this.userNameCheckPL);
            this.Controls.Add(this.emailCheckPL);
            this.Controls.Add(this.phoneCheckPL);
            this.Controls.Add(this.zipCodeCheckPL);
            this.Controls.Add(this.addressCheckPL);
            this.Controls.Add(this.cityCheckPL);
            this.Controls.Add(this.lastNameCheckPL);
            this.Controls.Add(this.firstNameCheckPL);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.RegisterUserBT);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.zipCodeTB);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Name = "RegisterFM";
            this.Text = "RegisterFM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox firstNameTB;
        private TextBox lastNameTB;
        private TextBox addressTB;
        private TextBox cityTB;
        private TextBox zipCodeTB;
        private TextBox emailTB;
        private TextBox phoneTB;
        private Button RegisterUserBT;
        private TextBox usernameTB;
        private TextBox passwordTB;
        private Panel firstNameCheckPL;
        private Panel addressCheckPL;
        private Panel lastNameCheckPL;
        private Panel emailCheckPL;
        private Panel zipCodeCheckPL;
        private Panel cityCheckPL;
        private Panel passwordCheckPL;
        private Panel userNameCheckPL;
        private Panel phoneCheckPL;
    }
}
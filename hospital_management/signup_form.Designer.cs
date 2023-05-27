namespace hospital_management
{
    partial class signup_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPasword = new System.Windows.Forms.Label();
            this.lblCnic = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(324, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(177, 112);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "UserName";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(177, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblPasword
            // 
            this.lblPasword.AutoSize = true;
            this.lblPasword.Location = new System.Drawing.Point(177, 217);
            this.lblPasword.Name = "lblPasword";
            this.lblPasword.Size = new System.Drawing.Size(53, 13);
            this.lblPasword.TabIndex = 3;
            this.lblPasword.Text = "Password";
            this.lblPasword.Click += new System.EventHandler(this.lblPasword_Click);
            // 
            // lblCnic
            // 
            this.lblCnic.AutoSize = true;
            this.lblCnic.Location = new System.Drawing.Point(177, 270);
            this.lblCnic.Name = "lblCnic";
            this.lblCnic.Size = new System.Drawing.Size(32, 13);
            this.lblCnic.TabIndex = 4;
            this.lblCnic.Text = "CNIC";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(356, 108);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(169, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(356, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(356, 214);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(169, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(356, 263);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(169, 20);
            this.txtCNIC.TabIndex = 9;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(329, 411);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(116, 35);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(356, 314);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(169, 20);
            this.txtContact.TabIndex = 11;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(177, 317);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 12;
            this.lblContact.Text = "Contact";
            // 
            // signup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 598);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblCnic);
            this.Controls.Add(this.lblPasword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Name = "signup_form";
            this.Text = "signup_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPasword;
        private System.Windows.Forms.Label lblCnic;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
    }
}
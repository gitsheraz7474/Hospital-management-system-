namespace hospital_management
{
    partial class Staff_information
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
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPositon = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(359, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStaffID.Location = new System.Drawing.Point(64, 173);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(65, 20);
            this.lblStaffID.TabIndex = 1;
            this.lblStaffID.Text = "Staff ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(64, 230);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGender.Location = new System.Drawing.Point(64, 281);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // lblPositon
            // 
            this.lblPositon.AutoSize = true;
            this.lblPositon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPositon.Location = new System.Drawing.Point(64, 344);
            this.lblPositon.Name = "lblPositon";
            this.lblPositon.Size = new System.Drawing.Size(65, 20);
            this.lblPositon.TabIndex = 4;
            this.lblPositon.Text = "Position";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSalary.Location = new System.Drawing.Point(503, 171);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(53, 20);
            this.lblSalary.TabIndex = 5;
            this.lblSalary.Text = "Salary";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblContact.Location = new System.Drawing.Point(503, 230);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(65, 20);
            this.lblContact.TabIndex = 6;
            this.lblContact.Text = "Contact";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(213, 173);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(152, 20);
            this.txtStaffID.TabIndex = 8;
            this.txtStaffID.TextChanged += new System.EventHandler(this.staffidtext_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(213, 230);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(213, 346);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(152, 20);
            this.txtPosition.TabIndex = 10;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(636, 175);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(168, 20);
            this.txtSalary.TabIndex = 11;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(636, 232);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(168, 20);
            this.txtContact.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(636, 296);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(168, 20);
            this.txtAddress.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(392, 408);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 40);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAddress.Location = new System.Drawing.Point(503, 296);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Address";
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(213, 284);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(48, 17);
            this.rdbMale.TabIndex = 19;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(306, 284);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbFemale.TabIndex = 20;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // Staff_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1001, 598);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblPositon);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.label1);
            this.Name = "Staff_information";
            this.Text = "Staff_information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPositon;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
    }
}
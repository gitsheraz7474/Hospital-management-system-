namespace hospital_management
{
    partial class Patient_Registration
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
            this.addbtn = new System.Windows.Forms.Button();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.txtRoomNO = new System.Windows.Forms.TextBox();
            this.txtPatientDisease = new System.Windows.Forms.TextBox();
            this.txtPatientcontact = new System.Windows.Forms.TextBox();
            this.txtPatientAge = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblDisease = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblPateintage = new System.Windows.Forms.Label();
            this.lblPatientGender = new System.Windows.Forms.Label();
            this.lblPatientid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(347, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register New Patient ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(453, 434);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(147, 38);
            this.addbtn.TabIndex = 26;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(656, 258);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(200, 21);
            this.cmbRoomType.TabIndex = 88;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(656, 204);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOut.TabIndex = 87;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(656, 151);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckIn.TabIndex = 86;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(303, 259);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbFemale.TabIndex = 85;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(235, 259);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(48, 17);
            this.rdbMale.TabIndex = 84;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalAmount.Location = new System.Drawing.Point(510, 346);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(104, 20);
            this.lblTotalAmount.TabIndex = 83;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(656, 348);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.txtTotalAmount.TabIndex = 82;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCheckOut.Location = new System.Drawing.Point(510, 204);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(84, 20);
            this.lblCheckOut.TabIndex = 81;
            this.lblCheckOut.Text = "Check Out";
            // 
            // txtRoomNO
            // 
            this.txtRoomNO.Location = new System.Drawing.Point(656, 307);
            this.txtRoomNO.Name = "txtRoomNO";
            this.txtRoomNO.Size = new System.Drawing.Size(200, 20);
            this.txtRoomNO.TabIndex = 80;
            // 
            // txtPatientDisease
            // 
            this.txtPatientDisease.Location = new System.Drawing.Point(235, 348);
            this.txtPatientDisease.Name = "txtPatientDisease";
            this.txtPatientDisease.Size = new System.Drawing.Size(152, 20);
            this.txtPatientDisease.TabIndex = 79;
            // 
            // txtPatientcontact
            // 
            this.txtPatientcontact.Location = new System.Drawing.Point(235, 401);
            this.txtPatientcontact.Name = "txtPatientcontact";
            this.txtPatientcontact.Size = new System.Drawing.Size(152, 20);
            this.txtPatientcontact.TabIndex = 78;
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.Location = new System.Drawing.Point(235, 305);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.Size = new System.Drawing.Size(152, 20);
            this.txtPatientAge.TabIndex = 77;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(235, 204);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(152, 20);
            this.txtPatientID.TabIndex = 76;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(235, 151);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(152, 20);
            this.txtPatientName.TabIndex = 75;
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRoomNo.Location = new System.Drawing.Point(510, 305);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(79, 20);
            this.lblRoomNo.TabIndex = 74;
            this.lblRoomNo.Text = "Room NO";
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDisease.Location = new System.Drawing.Point(87, 346);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(67, 20);
            this.lblDisease.TabIndex = 73;
            this.lblDisease.Text = "Disease";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRoomType.Location = new System.Drawing.Point(510, 259);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(90, 20);
            this.lblRoomType.TabIndex = 72;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCheckIn.Location = new System.Drawing.Point(510, 151);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(72, 20);
            this.lblCheckIn.TabIndex = 71;
            this.lblCheckIn.Text = "Check In";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblContact.Location = new System.Drawing.Point(87, 399);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(65, 20);
            this.lblContact.TabIndex = 70;
            this.lblContact.Text = "Contact";
            // 
            // lblPateintage
            // 
            this.lblPateintage.AutoSize = true;
            this.lblPateintage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPateintage.Location = new System.Drawing.Point(87, 299);
            this.lblPateintage.Name = "lblPateintage";
            this.lblPateintage.Size = new System.Drawing.Size(92, 20);
            this.lblPateintage.TabIndex = 69;
            this.lblPateintage.Text = "Patient Age";
            // 
            // lblPatientGender
            // 
            this.lblPatientGender.AutoSize = true;
            this.lblPatientGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPatientGender.Location = new System.Drawing.Point(87, 256);
            this.lblPatientGender.Name = "lblPatientGender";
            this.lblPatientGender.Size = new System.Drawing.Size(117, 20);
            this.lblPatientGender.TabIndex = 68;
            this.lblPatientGender.Text = "Patient Gender";
            // 
            // lblPatientid
            // 
            this.lblPatientid.AutoSize = true;
            this.lblPatientid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPatientid.Location = new System.Drawing.Point(87, 202);
            this.lblPatientid.Name = "lblPatientid";
            this.lblPatientid.Size = new System.Drawing.Size(80, 20);
            this.lblPatientid.TabIndex = 67;
            this.lblPatientid.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(87, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Patient Name";
            // 
            // Patient_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1001, 598);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.txtRoomNO);
            this.Controls.Add(this.txtPatientDisease);
            this.Controls.Add(this.txtPatientcontact);
            this.Controls.Add(this.txtPatientAge);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.lblDisease);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblPateintage);
            this.Controls.Add(this.lblPatientGender);
            this.Controls.Add(this.lblPatientid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label1);
            this.Name = "Patient_Registration";
            this.Text = "Patient_Registration";
            this.Load += new System.EventHandler(this.Patient_Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.TextBox txtRoomNO;
        private System.Windows.Forms.TextBox txtPatientDisease;
        private System.Windows.Forms.TextBox txtPatientcontact;
        private System.Windows.Forms.TextBox txtPatientAge;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblPateintage;
        private System.Windows.Forms.Label lblPatientGender;
        private System.Windows.Forms.Label lblPatientid;
        private System.Windows.Forms.Label label2;
    }
}
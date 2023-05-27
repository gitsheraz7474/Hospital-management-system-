namespace hospital_management
{
    partial class Room_information
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
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblNoofBed = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.txtNoofBed = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.bntAdd = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(364, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRoomType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRoomType.Location = new System.Drawing.Point(119, 221);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(90, 20);
            this.lblRoomType.TabIndex = 2;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblNoofBed
            // 
            this.lblNoofBed.AutoSize = true;
            this.lblNoofBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNoofBed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNoofBed.Location = new System.Drawing.Point(509, 157);
            this.lblNoofBed.Name = "lblNoofBed";
            this.lblNoofBed.Size = new System.Drawing.Size(80, 20);
            this.lblNoofBed.TabIndex = 3;
            this.lblNoofBed.Text = "No.of Bed";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrice.Location = new System.Drawing.Point(509, 219);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(509, 285);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRoomNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRoomNo.Location = new System.Drawing.Point(119, 287);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(76, 20);
            this.lblRoomNo.TabIndex = 6;
            this.lblRoomNo.Text = "Room No";
            this.lblRoomNo.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(259, 287);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(146, 20);
            this.txtRoomNo.TabIndex = 9;
            // 
            // txtNoofBed
            // 
            this.txtNoofBed.Location = new System.Drawing.Point(652, 159);
            this.txtNoofBed.Name = "txtNoofBed";
            this.txtNoofBed.Size = new System.Drawing.Size(142, 20);
            this.txtNoofBed.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(652, 221);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(142, 20);
            this.txtPrice.TabIndex = 11;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(652, 287);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(142, 20);
            this.txtStatus.TabIndex = 12;
            // 
            // bntAdd
            // 
            this.bntAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntAdd.Location = new System.Drawing.Point(370, 390);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(109, 32);
            this.bntAdd.TabIndex = 13;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            // 
            // viewbtn
            // 
            this.viewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewbtn.Location = new System.Drawing.Point(565, 390);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(110, 32);
            this.viewbtn.TabIndex = 15;
            this.viewbtn.Text = "View";
            this.viewbtn.UseVisualStyleBackColor = true;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(259, 157);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(146, 20);
            this.txtPatientID.TabIndex = 17;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPatientID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPatientID.Location = new System.Drawing.Point(119, 157);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(80, 20);
            this.lblPatientID.TabIndex = 16;
            this.lblPatientID.Text = "Patient ID";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(259, 221);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(146, 21);
            this.cmbRoomType.TabIndex = 18;
            // 
            // Room_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1001, 598);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNoofBed);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNoofBed);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Room_information";
            this.Text = "Room_information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblNoofBed;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.TextBox txtNoofBed;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.ComboBox cmbRoomType;
    }
}
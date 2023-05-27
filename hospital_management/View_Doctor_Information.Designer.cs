namespace hospital_management
{
    partial class View_Doctor_Information
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
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.dgvViewDoctorInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewDoctorInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(443, 127);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(152, 20);
            this.txtDoctorID.TabIndex = 29;
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDoctorID.Location = new System.Drawing.Point(294, 127);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(78, 20);
            this.lblDoctorID.TabIndex = 28;
            this.lblDoctorID.Text = "Doctor ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "View Doctor Information";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(380, 193);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 32);
            this.btnView.TabIndex = 31;
            this.btnView.Text = "View ";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByID.Location = new System.Drawing.Point(518, 193);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(136, 31);
            this.btnSearchByID.TabIndex = 32;
            this.btnSearchByID.Text = "Search By ID";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            // 
            // dgvViewDoctorInfo
            // 
            this.dgvViewDoctorInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewDoctorInfo.Location = new System.Drawing.Point(0, 231);
            this.dgvViewDoctorInfo.Name = "dgvViewDoctorInfo";
            this.dgvViewDoctorInfo.Size = new System.Drawing.Size(1005, 310);
            this.dgvViewDoctorInfo.TabIndex = 33;
            // 
            // View_Doctor_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1001, 598);
            this.Controls.Add(this.dgvViewDoctorInfo);
            this.Controls.Add(this.btnSearchByID);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.lblDoctorID);
            this.Name = "View_Doctor_Information";
            this.Text = "View_Doctor_Information";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewDoctorInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSearchByID;
        private System.Windows.Forms.DataGridView dgvViewDoctorInfo;
    }
}
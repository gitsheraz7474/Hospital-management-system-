namespace hospital_management
{
    partial class View_Staff_Information
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
            this.bntView = new System.Windows.Forms.Button();
            this.bntSearchByID = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvViewStaffInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStaffInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Staff Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(262, 135);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(73, 20);
            this.lblStaffID.TabIndex = 1;
            this.lblStaffID.Text = "Staff ID";
            // 
            // bntView
            // 
            this.bntView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntView.Location = new System.Drawing.Point(375, 211);
            this.bntView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bntView.Name = "bntView";
            this.bntView.Size = new System.Drawing.Size(127, 36);
            this.bntView.TabIndex = 2;
            this.bntView.Text = "View";
            this.bntView.UseVisualStyleBackColor = true;
            this.bntView.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntSearchByID
            // 
            this.bntSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSearchByID.Location = new System.Drawing.Point(545, 211);
            this.bntSearchByID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bntSearchByID.Name = "bntSearchByID";
            this.bntSearchByID.Size = new System.Drawing.Size(148, 35);
            this.bntSearchByID.TabIndex = 3;
            this.bntSearchByID.Text = "Search  By ID";
            this.bntSearchByID.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(334, 637);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 288);
            this.dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(394, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 31);
            this.textBox1.TabIndex = 5;
            // 
            // dgvViewStaffInfo
            // 
            this.dgvViewStaffInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStaffInfo.Location = new System.Drawing.Point(12, 268);
            this.dgvViewStaffInfo.Name = "dgvViewStaffInfo";
            this.dgvViewStaffInfo.Size = new System.Drawing.Size(988, 270);
            this.dgvViewStaffInfo.TabIndex = 6;
            // 
            // View_Staff_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1001, 598);
            this.Controls.Add(this.dgvViewStaffInfo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntSearchByID);
            this.Controls.Add(this.bntView);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "View_Staff_Information";
            this.Text = "View_Staff_Information";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStaffInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Button bntView;
        private System.Windows.Forms.Button bntSearchByID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvViewStaffInfo;
    }
}
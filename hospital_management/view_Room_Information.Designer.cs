﻿namespace hospital_management
{
    partial class view_Room_Information
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
            this.dgvRoomInformation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoomInformation
            // 
            this.dgvRoomInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomInformation.Location = new System.Drawing.Point(2, 136);
            this.dgvRoomInformation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvRoomInformation.Name = "dgvRoomInformation";
            this.dgvRoomInformation.Size = new System.Drawing.Size(997, 403);
            this.dgvRoomInformation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Room Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // view_Room_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1001, 598);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRoomInformation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "view_Room_Information";
            this.Text = "view_Room_Information";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoomInformation;
        private System.Windows.Forms.Label label1;
    }
}
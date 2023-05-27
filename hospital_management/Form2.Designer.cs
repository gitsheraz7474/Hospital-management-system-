namespace hospital_management
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.patientregistraionlabel = new System.Windows.Forms.Label();
            this.patientinfolabel = new System.Windows.Forms.Label();
            this.checkoutlabel = new System.Windows.Forms.Label();
            this.roominfolabel = new System.Windows.Forms.Label();
            this.addstafflabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(251, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital System";
            // 
            // patientregistraionlabel
            // 
            this.patientregistraionlabel.AutoSize = true;
            this.patientregistraionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.patientregistraionlabel.Location = new System.Drawing.Point(-2, 92);
            this.patientregistraionlabel.Name = "patientregistraionlabel";
            this.patientregistraionlabel.Size = new System.Drawing.Size(179, 25);
            this.patientregistraionlabel.TabIndex = 1;
            this.patientregistraionlabel.Text = "Patient Registration";
            // 
            // patientinfolabel
            // 
            this.patientinfolabel.AutoSize = true;
            this.patientinfolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.patientinfolabel.Location = new System.Drawing.Point(-1, 146);
            this.patientinfolabel.Name = "patientinfolabel";
            this.patientinfolabel.Size = new System.Drawing.Size(173, 25);
            this.patientinfolabel.TabIndex = 2;
            this.patientinfolabel.Text = "Patient Information";
            // 
            // checkoutlabel
            // 
            this.checkoutlabel.AutoSize = true;
            this.checkoutlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.checkoutlabel.Location = new System.Drawing.Point(-2, 192);
            this.checkoutlabel.Name = "checkoutlabel";
            this.checkoutlabel.Size = new System.Drawing.Size(106, 25);
            this.checkoutlabel.TabIndex = 3;
            this.checkoutlabel.Text = "Check Out";
            // 
            // roominfolabel
            // 
            this.roominfolabel.AutoSize = true;
            this.roominfolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.roominfolabel.Location = new System.Drawing.Point(-2, 242);
            this.roominfolabel.Name = "roominfolabel";
            this.roominfolabel.Size = new System.Drawing.Size(100, 25);
            this.roominfolabel.TabIndex = 4;
            this.roominfolabel.Text = "Room Info";
            // 
            // addstafflabel
            // 
            this.addstafflabel.AutoSize = true;
            this.addstafflabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addstafflabel.Location = new System.Drawing.Point(-2, 289);
            this.addstafflabel.Name = "addstafflabel";
            this.addstafflabel.Size = new System.Drawing.Size(93, 25);
            this.addstafflabel.TabIndex = 5;
            this.addstafflabel.Text = "Add Staff";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.addstafflabel);
            this.Controls.Add(this.roominfolabel);
            this.Controls.Add(this.checkoutlabel);
            this.Controls.Add(this.patientinfolabel);
            this.Controls.Add(this.patientregistraionlabel);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "welcome page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label patientregistraionlabel;
        private System.Windows.Forms.Label patientinfolabel;
        private System.Windows.Forms.Label checkoutlabel;
        private System.Windows.Forms.Label roominfolabel;
        private System.Windows.Forms.Label addstafflabel;
    }
}
namespace SHEILLA_COMPANY
{
    partial class landMGMT
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LandUPITxt = new System.Windows.Forms.TextBox();
            this.LandSizeTxt = new System.Windows.Forms.TextBox();
            this.LandLocationTxt = new System.Windows.Forms.TextBox();
            this.LandTypeTxt = new System.Windows.Forms.ComboBox();
            this.LandDescriptionTxt = new System.Windows.Forms.RichTextBox();
            this.BtnSaveLandDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LAND MANAGEMENT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "UPI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // LandUPITxt
            // 
            this.LandUPITxt.Location = new System.Drawing.Point(192, 106);
            this.LandUPITxt.Name = "LandUPITxt";
            this.LandUPITxt.Size = new System.Drawing.Size(184, 26);
            this.LandUPITxt.TabIndex = 6;
            // 
            // LandSizeTxt
            // 
            this.LandSizeTxt.Location = new System.Drawing.Point(192, 153);
            this.LandSizeTxt.Name = "LandSizeTxt";
            this.LandSizeTxt.Size = new System.Drawing.Size(184, 26);
            this.LandSizeTxt.TabIndex = 7;
            // 
            // LandLocationTxt
            // 
            this.LandLocationTxt.Location = new System.Drawing.Point(539, 153);
            this.LandLocationTxt.Name = "LandLocationTxt";
            this.LandLocationTxt.Size = new System.Drawing.Size(184, 26);
            this.LandLocationTxt.TabIndex = 8;
            // 
            // LandTypeTxt
            // 
            this.LandTypeTxt.FormattingEnabled = true;
            this.LandTypeTxt.Items.AddRange(new object[] {
            "R1",
            "R2",
            "R3",
            "OTHER"});
            this.LandTypeTxt.Location = new System.Drawing.Point(539, 106);
            this.LandTypeTxt.Name = "LandTypeTxt";
            this.LandTypeTxt.Size = new System.Drawing.Size(184, 28);
            this.LandTypeTxt.TabIndex = 9;
            // 
            // LandDescriptionTxt
            // 
            this.LandDescriptionTxt.Location = new System.Drawing.Point(216, 210);
            this.LandDescriptionTxt.Name = "LandDescriptionTxt";
            this.LandDescriptionTxt.Size = new System.Drawing.Size(507, 76);
            this.LandDescriptionTxt.TabIndex = 10;
            this.LandDescriptionTxt.Text = "";
            // 
            // BtnSaveLandDetails
            // 
            this.BtnSaveLandDetails.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSaveLandDetails.ForeColor = System.Drawing.Color.White;
            this.BtnSaveLandDetails.Location = new System.Drawing.Point(323, 334);
            this.BtnSaveLandDetails.Name = "BtnSaveLandDetails";
            this.BtnSaveLandDetails.Size = new System.Drawing.Size(166, 39);
            this.BtnSaveLandDetails.TabIndex = 11;
            this.BtnSaveLandDetails.Text = "SAVE";
            this.BtnSaveLandDetails.UseVisualStyleBackColor = false;
            this.BtnSaveLandDetails.Click += new System.EventHandler(this.BtnSaveLandDetails_Click);
            // 
            // landMGMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSaveLandDetails);
            this.Controls.Add(this.LandDescriptionTxt);
            this.Controls.Add(this.LandTypeTxt);
            this.Controls.Add(this.LandLocationTxt);
            this.Controls.Add(this.LandSizeTxt);
            this.Controls.Add(this.LandUPITxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "landMGMT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "landMGMT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LandUPITxt;
        private System.Windows.Forms.TextBox LandSizeTxt;
        private System.Windows.Forms.TextBox LandLocationTxt;
        private System.Windows.Forms.ComboBox LandTypeTxt;
        private System.Windows.Forms.RichTextBox LandDescriptionTxt;
        private System.Windows.Forms.Button BtnSaveLandDetails;
    }
}
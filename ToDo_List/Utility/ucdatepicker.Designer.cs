namespace ToDo_List.Utility
{
    partial class ucdatepicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbmonth = new System.Windows.Forms.ComboBox();
            this.txtyear = new System.Windows.Forms.NumericUpDown();
            this.lbldate = new System.Windows.Forms.Label();
            this.btndhowhide = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtyear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(3, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "پ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "س";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ی";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "چ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "د";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ش";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(16, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ج";
            // 
            // cbmonth
            // 
            this.cbmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmonth.FormattingEnabled = true;
            this.cbmonth.Location = new System.Drawing.Point(87, 4);
            this.cbmonth.Name = "cbmonth";
            this.cbmonth.Size = new System.Drawing.Size(70, 21);
            this.cbmonth.TabIndex = 2;
            this.cbmonth.SelectedIndexChanged += new System.EventHandler(this.cbmonth_SelectedIndexChanged);
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(13, 5);
            this.txtyear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtyear.Minimum = new decimal(new int[] {
            1111,
            0,
            0,
            0});
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(60, 20);
            this.txtyear.TabIndex = 3;
            this.txtyear.Value = new decimal(new int[] {
            1111,
            0,
            0,
            0});
            this.txtyear.ValueChanged += new System.EventHandler(this.txtyear_ValueChanged);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbldate.Location = new System.Drawing.Point(176, 7);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(0, 13);
            this.lbldate.TabIndex = 4;
            this.lbldate.TextChanged += new System.EventHandler(this.lbldate_TextChanged);
            // 
            // btndhowhide
            // 
            this.btndhowhide.Location = new System.Drawing.Point(298, 5);
            this.btndhowhide.Name = "btndhowhide";
            this.btndhowhide.Size = new System.Drawing.Size(22, 23);
            this.btndhowhide.TabIndex = 5;
            this.btndhowhide.Text = "V";
            this.btndhowhide.UseVisualStyleBackColor = true;
            this.btndhowhide.Click += new System.EventHandler(this.btndhowhide_Click);
            // 
            // ucdatepicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btndhowhide);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.cbmonth);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucdatepicker";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(339, 286);
            this.Load += new System.EventHandler(this.uccalender_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtyear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.ComboBox cbmonth;
        private System.Windows.Forms.NumericUpDown txtyear;
        internal System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button btndhowhide;
    }
}

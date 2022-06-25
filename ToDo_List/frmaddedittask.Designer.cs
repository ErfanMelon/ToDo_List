namespace ToDo_List
{
    partial class frmaddedittask
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaddedittask));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdetail = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbstate = new System.Windows.Forms.CheckBox();
            this.txttaskname = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.nishowresult = new System.Windows.Forms.NotifyIcon(this.components);
            this.dtpreminder = new ToDo_List.Utility.ucdatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmin = new System.Windows.Forms.NumericUpDown();
            this.txthour = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbreminder = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthour)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdetail);
            this.groupBox1.Location = new System.Drawing.Point(14, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "توضیحات";
            // 
            // txtdetail
            // 
            this.txtdetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtdetail.Location = new System.Drawing.Point(3, 16);
            this.txtdetail.Name = "txtdetail";
            this.txtdetail.Size = new System.Drawing.Size(382, 193);
            this.txtdetail.TabIndex = 0;
            this.txtdetail.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کار :";
            // 
            // cbstate
            // 
            this.cbstate.AutoSize = true;
            this.cbstate.Location = new System.Drawing.Point(169, 19);
            this.cbstate.Name = "cbstate";
            this.cbstate.Size = new System.Drawing.Size(59, 17);
            this.cbstate.TabIndex = 2;
            this.cbstate.Text = "وضعیت";
            this.cbstate.UseVisualStyleBackColor = true;
            // 
            // txttaskname
            // 
            this.txttaskname.Location = new System.Drawing.Point(239, 16);
            this.txttaskname.Name = "txttaskname";
            this.txttaskname.Size = new System.Drawing.Size(100, 20);
            this.txttaskname.TabIndex = 3;
            this.txttaskname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(15, 16);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "افزودن";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // nishowresult
            // 
            this.nishowresult.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nishowresult.Icon = ((System.Drawing.Icon)(resources.GetObject("nishowresult.Icon")));
            this.nishowresult.Text = "متن پیام";
            this.nishowresult.BalloonTipClosed += new System.EventHandler(this.nishowresult_BalloonTipClosed);
            // 
            // dtpreminder
            // 
            this.dtpreminder.day = 0;
            this.dtpreminder.Enabled = false;
            this.dtpreminder.Location = new System.Drawing.Point(14, 48);
            this.dtpreminder.month = 4;
            this.dtpreminder.Name = "dtpreminder";
            this.dtpreminder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpreminder.Size = new System.Drawing.Size(339, 32);
            this.dtpreminder.TabIndex = 5;
            this.dtpreminder.year = 1401;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(350, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "تاریخ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(356, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "زمان :";
            // 
            // txtmin
            // 
            this.txtmin.Enabled = false;
            this.txtmin.Location = new System.Drawing.Point(312, 88);
            this.txtmin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(38, 20);
            this.txtmin.TabIndex = 8;
            // 
            // txthour
            // 
            this.txthour.Enabled = false;
            this.txthour.Location = new System.Drawing.Point(259, 88);
            this.txthour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txthour.Name = "txthour";
            this.txthour.Size = new System.Drawing.Size(38, 20);
            this.txthour.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // cbreminder
            // 
            this.cbreminder.AutoSize = true;
            this.cbreminder.Location = new System.Drawing.Point(109, 20);
            this.cbreminder.Name = "cbreminder";
            this.cbreminder.Size = new System.Drawing.Size(55, 17);
            this.cbreminder.TabIndex = 10;
            this.cbreminder.Text = "هشدار";
            this.cbreminder.UseVisualStyleBackColor = true;
            this.cbreminder.CheckedChanged += new System.EventHandler(this.cbreminder_CheckedChanged);
            // 
            // frmaddedittask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 343);
            this.Controls.Add(this.cbreminder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthour);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpreminder);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txttaskname);
            this.Controls.Add(this.cbstate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmaddedittask";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "افزودن";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtdetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbstate;
        private System.Windows.Forms.TextBox txttaskname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.NotifyIcon nishowresult;
        private Utility.ucdatepicker dtpreminder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtmin;
        private System.Windows.Forms.NumericUpDown txthour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbreminder;
    }
}
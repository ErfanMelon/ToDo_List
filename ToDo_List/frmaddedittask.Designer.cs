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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdetail);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "توضیحات";
            // 
            // txtdetail
            // 
            this.txtdetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtdetail.Location = new System.Drawing.Point(3, 16);
            this.txtdetail.Name = "txtdetail";
            this.txtdetail.Size = new System.Drawing.Size(382, 120);
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
            this.cbstate.Location = new System.Drawing.Point(130, 19);
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
            // frmaddedittask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 191);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txttaskname);
            this.Controls.Add(this.cbstate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmaddedittask";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "افزودن";
            this.Load += new System.EventHandler(this.frmaddedittask_Load);
            this.groupBox1.ResumeLayout(false);
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
    }
}
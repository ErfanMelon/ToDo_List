namespace ToDo_List
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnaddnewtask = new System.Windows.Forms.ToolStripButton();
            this.btnsetting = new System.Windows.Forms.ToolStripDropDownButton();
            this.btndeletedb = new System.Windows.Forms.ToolStripMenuItem();
            this.gbcategories = new System.Windows.Forms.GroupBox();
            this.btndidnt = new System.Windows.Forms.Button();
            this.btndone = new System.Windows.Forms.Button();
            this.btnalltasks = new System.Windows.Forms.Button();
            this.pltasks = new System.Windows.Forms.Panel();
            this.nideletedbmessege = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.gbcategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnaddnewtask,
            this.btnsetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(625, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnaddnewtask
            // 
            this.btnaddnewtask.Image = global::ToDo_List.Properties.Resources._new;
            this.btnaddnewtask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnaddnewtask.Name = "btnaddnewtask";
            this.btnaddnewtask.Size = new System.Drawing.Size(87, 35);
            this.btnaddnewtask.Text = "افزودن کار جدید";
            this.btnaddnewtask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnaddnewtask.Click += new System.EventHandler(this.btnaddnewtask_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btndeletedb});
            this.btnsetting.Image = global::ToDo_List.Properties.Resources.setting;
            this.btnsetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(63, 35);
            this.btnsetting.Text = "تنظیمات";
            this.btnsetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            // 
            // btndeletedb
            // 
            this.btndeletedb.Name = "btndeletedb";
            this.btndeletedb.Size = new System.Drawing.Size(137, 22);
            this.btndeletedb.Text = "حذف داده ها";
            this.btndeletedb.Click += new System.EventHandler(this.btndeletedb_Click);
            // 
            // gbcategories
            // 
            this.gbcategories.Controls.Add(this.pictureBox1);
            this.gbcategories.Controls.Add(this.btndidnt);
            this.gbcategories.Controls.Add(this.btndone);
            this.gbcategories.Controls.Add(this.btnalltasks);
            this.gbcategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbcategories.Location = new System.Drawing.Point(0, 38);
            this.gbcategories.Name = "gbcategories";
            this.gbcategories.Size = new System.Drawing.Size(625, 83);
            this.gbcategories.TabIndex = 1;
            this.gbcategories.TabStop = false;
            this.gbcategories.Text = "دسته بندی ها";
            // 
            // btndidnt
            // 
            this.btndidnt.Location = new System.Drawing.Point(250, 29);
            this.btndidnt.Name = "btndidnt";
            this.btndidnt.Size = new System.Drawing.Size(75, 23);
            this.btndidnt.TabIndex = 1;
            this.btndidnt.Text = "انجام نشده";
            this.btndidnt.UseVisualStyleBackColor = true;
            this.btndidnt.Click += new System.EventHandler(this.btndidnt_Click);
            // 
            // btndone
            // 
            this.btndone.Location = new System.Drawing.Point(169, 29);
            this.btndone.Name = "btndone";
            this.btndone.Size = new System.Drawing.Size(75, 23);
            this.btndone.TabIndex = 1;
            this.btndone.Text = "انجام شده";
            this.btndone.UseVisualStyleBackColor = true;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // btnalltasks
            // 
            this.btnalltasks.Location = new System.Drawing.Point(88, 29);
            this.btnalltasks.Name = "btnalltasks";
            this.btnalltasks.Size = new System.Drawing.Size(75, 23);
            this.btnalltasks.TabIndex = 0;
            this.btnalltasks.Text = "همه وظایف";
            this.btnalltasks.UseVisualStyleBackColor = true;
            this.btnalltasks.ContextMenuStripChanged += new System.EventHandler(this.btnalltasks_ContextMenuStripChanged);
            this.btnalltasks.Click += new System.EventHandler(this.btnalltasks_Click);
            // 
            // pltasks
            // 
            this.pltasks.AutoScroll = true;
            this.pltasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pltasks.Location = new System.Drawing.Point(0, 121);
            this.pltasks.Name = "pltasks";
            this.pltasks.Size = new System.Drawing.Size(625, 354);
            this.pltasks.TabIndex = 2;
            // 
            // nideletedbmessege
            // 
            this.nideletedbmessege.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nideletedbmessege.Icon = ((System.Drawing.Icon)(resources.GetObject("nideletedbmessege.Icon")));
            this.nideletedbmessege.Text = "Delete";
            this.nideletedbmessege.BalloonTipClosed += new System.EventHandler(this.nideletedbmessege_BalloonTipClosed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 475);
            this.Controls.Add(this.pltasks);
            this.Controls.Add(this.gbcategories);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت انجام کارها";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbcategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox gbcategories;
        private System.Windows.Forms.Button btndidnt;
        private System.Windows.Forms.Button btndone;
        private System.Windows.Forms.Button btnalltasks;
        private System.Windows.Forms.Panel pltasks;
        private System.Windows.Forms.ToolStripButton btnaddnewtask;
        private System.Windows.Forms.ToolStripDropDownButton btnsetting;
        private System.Windows.Forms.ToolStripMenuItem btndeletedb;
        private System.Windows.Forms.NotifyIcon nideletedbmessege;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnaddnewtask = new System.Windows.Forms.ToolStripButton();
            this.gbcategories = new System.Windows.Forms.GroupBox();
            this.btndidnt = new System.Windows.Forms.Button();
            this.btndone = new System.Windows.Forms.Button();
            this.btnalltasks = new System.Windows.Forms.Button();
            this.pltasks = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.gbcategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnaddnewtask});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(625, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnaddnewtask
            // 
            this.btnaddnewtask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnaddnewtask.Image = ((System.Drawing.Image)(resources.GetObject("btnaddnewtask.Image")));
            this.btnaddnewtask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnaddnewtask.Name = "btnaddnewtask";
            this.btnaddnewtask.Size = new System.Drawing.Size(87, 22);
            this.btnaddnewtask.Text = "افزودن کار جدید";
            this.btnaddnewtask.Click += new System.EventHandler(this.btnaddnewtask_Click);
            // 
            // gbcategories
            // 
            this.gbcategories.Controls.Add(this.btndidnt);
            this.gbcategories.Controls.Add(this.btndone);
            this.gbcategories.Controls.Add(this.btnalltasks);
            this.gbcategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbcategories.Location = new System.Drawing.Point(0, 25);
            this.gbcategories.Name = "gbcategories";
            this.gbcategories.Size = new System.Drawing.Size(625, 83);
            this.gbcategories.TabIndex = 1;
            this.gbcategories.TabStop = false;
            this.gbcategories.Text = "دسته بندی ها";
            // 
            // btndidnt
            // 
            this.btndidnt.Location = new System.Drawing.Point(100, 19);
            this.btndidnt.Name = "btndidnt";
            this.btndidnt.Size = new System.Drawing.Size(75, 23);
            this.btndidnt.TabIndex = 1;
            this.btndidnt.Text = "انجام نشده";
            this.btndidnt.UseVisualStyleBackColor = true;
            this.btndidnt.Click += new System.EventHandler(this.btndidnt_Click);
            // 
            // btndone
            // 
            this.btndone.Location = new System.Drawing.Point(19, 47);
            this.btndone.Name = "btndone";
            this.btndone.Size = new System.Drawing.Size(75, 23);
            this.btndone.TabIndex = 1;
            this.btndone.Text = "انجام شده";
            this.btndone.UseVisualStyleBackColor = true;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // btnalltasks
            // 
            this.btnalltasks.Location = new System.Drawing.Point(19, 18);
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
            this.pltasks.Location = new System.Drawing.Point(0, 108);
            this.pltasks.Name = "pltasks";
            this.pltasks.Size = new System.Drawing.Size(625, 367);
            this.pltasks.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 475);
            this.Controls.Add(this.pltasks);
            this.Controls.Add(this.gbcategories);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت انجام کارها";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbcategories.ResumeLayout(false);
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
    }
}
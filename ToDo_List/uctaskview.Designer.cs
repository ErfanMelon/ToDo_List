namespace ToDo_List
{
    partial class uctaskview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctaskview));
            this.cbtasknameandstate = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbdescription = new System.Windows.Forms.Label();
            this.ttdetail = new System.Windows.Forms.ToolTip(this.components);
            this.cmsrightclick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnremovetask = new System.Windows.Forms.ToolStripMenuItem();
            this.btnedittask = new System.Windows.Forms.ToolStripMenuItem();
            this.ninotif = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.cmsrightclick.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbtasknameandstate
            // 
            this.cbtasknameandstate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbtasknameandstate.AutoSize = true;
            this.cbtasknameandstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtasknameandstate.Location = new System.Drawing.Point(240, 3);
            this.cbtasknameandstate.Name = "cbtasknameandstate";
            this.cbtasknameandstate.Size = new System.Drawing.Size(63, 24);
            this.cbtasknameandstate.TabIndex = 0;
            this.cbtasknameandstate.Text = "نام کار";
            this.cbtasknameandstate.UseVisualStyleBackColor = true;
            this.cbtasknameandstate.CheckedChanged += new System.EventHandler(this.cbtasknameandstate_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbdescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 47);
            this.panel1.TabIndex = 2;
            this.panel1.DoubleClick += new System.EventHandler(this.uctaskview_MouseClick);
            // 
            // lbdescription
            // 
            this.lbdescription.AutoSize = true;
            this.lbdescription.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbdescription.Location = new System.Drawing.Point(257, 0);
            this.lbdescription.Name = "lbdescription";
            this.lbdescription.Size = new System.Drawing.Size(49, 13);
            this.lbdescription.TabIndex = 1;
            this.lbdescription.Text = "توضیحات";
            this.lbdescription.MouseHover += new System.EventHandler(this.lbdescription_MouseHover);
            // 
            // ttdetail
            // 
            this.ttdetail.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttdetail.ToolTipTitle = "توضیحات";
            // 
            // cmsrightclick
            // 
            this.cmsrightclick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnremovetask,
            this.btnedittask});
            this.cmsrightclick.Name = "cmsrightclick";
            this.cmsrightclick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsrightclick.ShowImageMargin = false;
            this.cmsrightclick.Size = new System.Drawing.Size(93, 48);
            // 
            // btnremovetask
            // 
            this.btnremovetask.Name = "btnremovetask";
            this.btnremovetask.Size = new System.Drawing.Size(92, 22);
            this.btnremovetask.Text = "Remove";
            this.btnremovetask.Click += new System.EventHandler(this.btnremovetask_Click);
            // 
            // btnedittask
            // 
            this.btnedittask.Name = "btnedittask";
            this.btnedittask.Size = new System.Drawing.Size(92, 22);
            this.btnedittask.Text = "Edit";
            this.btnedittask.Click += new System.EventHandler(this.btnedittask_Click);
            // 
            // ninotif
            // 
            this.ninotif.Icon = ((System.Drawing.Icon)(resources.GetObject("ninotif.Icon")));
            this.ninotif.Text = "حذف";
            this.ninotif.BalloonTipClosed += new System.EventHandler(this.ninotif_BalloonTipClosed);
            // 
            // uctaskview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.cmsrightclick;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbtasknameandstate);
            this.Name = "uctaskview";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(306, 91);
            this.DoubleClick += new System.EventHandler(this.uctaskview_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsrightclick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbtasknameandstate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbdescription;
        private System.Windows.Forms.ToolTip ttdetail;
        private System.Windows.Forms.ContextMenuStrip cmsrightclick;
        private System.Windows.Forms.ToolStripMenuItem btnremovetask;
        private System.Windows.Forms.ToolStripMenuItem btnedittask;
        private System.Windows.Forms.NotifyIcon ninotif;
    }
}

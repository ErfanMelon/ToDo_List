namespace ToDo_List
{
    partial class Form1
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
            this.uccalender1 = new ToDo_List.Utility.uccalender();
            this.SuspendLayout();
            // 
            // uccalender1
            // 
            this.uccalender1.Location = new System.Drawing.Point(12, 12);
            this.uccalender1.month = 4;
            this.uccalender1.Name = "uccalender1";
            this.uccalender1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uccalender1.shamsidate = null;
            this.uccalender1.Size = new System.Drawing.Size(339, 274);
            this.uccalender1.TabIndex = 0;
            this.uccalender1.year = 0;
            this.uccalender1.Load += new System.EventHandler(this.uccalender1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uccalender1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Utility.uccalender uccalender1;
    }
}
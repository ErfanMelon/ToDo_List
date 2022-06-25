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
            this.ucdatepicker1 = new ToDo_List.Utility.ucdatepicker();
            this.SuspendLayout();
            // 
            // ucdatepicker1
            // 
            this.ucdatepicker1.day = 0;
            this.ucdatepicker1.Location = new System.Drawing.Point(22, 12);
            this.ucdatepicker1.month = 4;
            this.ucdatepicker1.Name = "ucdatepicker1";
            this.ucdatepicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucdatepicker1.Size = new System.Drawing.Size(339, 286);
            this.ucdatepicker1.TabIndex = 0;
            this.ucdatepicker1.year = 1401;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucdatepicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Utility.ucdatepicker ucdatepicker1;
    }
}
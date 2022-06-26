using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ToDo_List.Utility
{
    public partial class customLabel : Label
    {
        private ucdatepicker datepicker = null;
        public customLabel(ucdatepicker callingform)
        {
            InitializeComponent();
            datepicker = callingform as ucdatepicker;
        }

        public customLabel(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private void customLabel_Click(object sender, EventArgs e)
        {
            datepicker.day = int.Parse(this.Text);
            datepicker.lbldate.Text = $"{datepicker.year}/{datepicker.month}/{datepicker.day}";
        }
    }
}
